namespace ScoreDashboard.Services

open System.ComponentModel
open System.Collections.Specialized

open BeloSoft.Data

open BeloSoft.Betfair.StreamingAPI
open BeloSoft.Betfair.StreamingAPI.Models

open BeloSoft.Bfexplorer
open BeloSoft.Bfexplorer.Domain
open BeloSoft.Bfexplorer.Service
open BeloSoft.Bfexplorer.Trading

/// <summary>
/// ScoreUpdateService
/// </summary>
type ScoreUpdateService() =

    let bfexplorerService = BfexplorerService(initializeBotManager = false, UiApplication = BfexplorerHost())
    let mutable marketUpdateService = nil<MarketUpdateService>

    let startTheBot market =
        let bot = FootballBot(market, FootballBotParameters(), bfexplorerService)

        bfexplorerService.StartBot(market, bot)

    let rec onPropertyIsInPlayChanged = PropertyChangedEventHandler(fun sender args ->
        if args.PropertyName = "IsInPlay" 
        then 
            let market = sender :?> Market

            if market.IsInPlay
            then
                startTheBot market
                (market :> INotifyPropertyChanged).PropertyChanged.RemoveHandler onPropertyIsInPlayChanged
    )
    
    let setNotifyHandlers (market : Market) = 
        if market.IsInPlay
        then
            startTheBot market
        else
            (market :> INotifyPropertyChanged).PropertyChanged.AddHandler onPropertyIsInPlayChanged

    do
        (bfexplorerService.ServiceStatus.OutputMessages :> INotifyCollectionChanged).CollectionChanged.Add(fun args ->
            if args.Action = NotifyCollectionChangedAction.Add
            then
                let newOutputMessages = args.NewItems |> Seq.cast<OutputMessage>

                newOutputMessages
                |> Seq.iter (fun outputMessage -> printfn "%s" outputMessage.Message)
        )

    /// <summary>
    /// Start
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    member _this.Start(userName, password) = async {
        let! loginResult = bfexplorerService.Login(userName, password)

        if loginResult.IsSuccessResult
        then
            marketUpdateService <- new MarketUpdateService(bfexplorerService, StreamingData.MarketDataFilterForPassiveMarkets)

            marketUpdateService.OnMarketsOpened.Add(fun markets -> 
                    markets 
                    |> List.iter (fun market -> 
                        let betEvent = market.MarketInfo.BetEvent

                        printfn "%s - %s" betEvent.Details betEvent.Name
                        setNotifyHandlers market
                    )
                )

            let! startResult = marketUpdateService.Start()

            if startResult.IsSuccessResult
            then
                (* Football *)
                let filter = [ BetEventFilterParameter.BetEventTypeIds [| 1 |]; BetEventFilterParameter.Countries [| "GB" |]; BetEventFilterParameter.MarketTypeCodes [| "MATCH_ODDS" |] ]

                (* Tennis
                let filter = [ BetEventFilterParameter.BetEventTypeIds [| 2 |]; BetEventFilterParameter.MarketTypeCodes [| "MATCH_ODDS" |]; ]
                *)

                return! marketUpdateService.Subscribe(filter)
            else
                return Result.Failure startResult.FailureMessage
        else
            let _, _, failureMessage = loginResult.FailureResult

            return Result.Failure failureMessage
    }

    /// <summary>
    /// Stop
    /// </summary>
    member _this.Stop() = async {
        do! marketUpdateService.Stop()

        return! bfexplorerService.Logout()
    }