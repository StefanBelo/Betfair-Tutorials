module LoadAndSaveData

open BeloSoft.Data
open BeloSoft.Bfexplorer.Domain
open BeloSoft.Bfexplorer.Service

let isFootballMatchOddsMarket (market : Market) =
    let marketInfo = market.MarketInfo

    marketInfo.BetEventType.Id = 1 && marketInfo.MarketName = "Match Odds"

let Execute (filter : BetEventFilter) (bfexplorerService : BfexplorerService) = async {
    match! bfexplorerService.GetMarkets(filter) with
    | DataResult.Success markets ->

        let toSelectionsData =
            if isFootballMatchOddsMarket markets.Head
            then
                fun (market : Market) -> 
                    let selections = market.Selections

                    // Home;Draw;Away team odds
                    sprintf "%.2f;%.2f;%.2f" selections[0].LastPriceTraded selections[2].LastPriceTraded selections[1].LastPriceTraded
            else
                fun (market : Market) -> sprintf "Total macthed %.2f" market.TotalMatched

        markets
        |> List.iter (fun market -> 
                let marketInfo = market.MarketInfo
                
                printfn "%A;%s;%s" marketInfo.StartTime marketInfo.BetEvent.Name (toSelectionsData market)
            )

        return Result.Success

    | DataResult.Failure errorMessage -> return Result.Failure errorMessage
}