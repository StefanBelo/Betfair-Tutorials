open BeloSoft.Data
open BeloSoft.Bfexplorer
open BeloSoft.Bfexplorer.Domain
open BeloSoft.Bfexplorer.Service

let getUserNameAndPassword (argv : string[]) =
    if argv.Length = 2 then Some (argv.[0], argv.[1]) else None

/// <summary>
/// main
/// </summary>
/// <param name="argv"></param>
[<EntryPoint>]
let main argv =
    async {
        match getUserNameAndPassword argv with
        | Some (userName, password) ->

            let bfexplorerService = BfexplorerService(initializeBotManager = false, UiApplication = BfexplorerHost())

            match! bfexplorerService.Login(userName, password) with
            | DataSuccessFailure.Success _ ->

                let! result = 
                    bfexplorerService |> LoadAndSaveData.Execute [
                        BetEventFilterParameter.StartTime (DateRange.Today())
                        BetEventFilterParameter.BetEventTypeIds [| 1 |]
                        BetEventFilterParameter.MarketTypeCodes [| "MATCH_ODDS" |]
                    ]
                
                let statusCode =
                    if result.IsSuccessResult
                    then
                        0
                    else                                     
                        printfn "Failed to load and save data: %s" result.FailureMessage; -3
                
                do! bfexplorerService.Logout() |> Async.Ignore
                
                return statusCode

            | DataSuccessFailure.Failure (_, _, errorMessage) -> printfn "Failed to login: %s" errorMessage; return -2

        | None -> printfn "Please enter your betfair user name and password!"; return -1
    }
    |> Async.RunSynchronously