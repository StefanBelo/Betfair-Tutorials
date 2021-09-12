open System
open BeloSoft.Data
open ScoreDashboard.Services

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

            let scoreUpdateService = ScoreUpdateService()

            match! scoreUpdateService.Start(userName, password) with
            | Result.Success ->

                printfn "Press any key to exit."

                Console.ReadKey() |> ignore
                
                do! scoreUpdateService.Stop() |> Async.Ignore
                
                return 0

            | Result.Failure errorMessage -> printfn "Failed to start: %s" errorMessage; return -2

        | None -> printfn "Please enter your betfair user name and password!"; return -1
    }
    |> Async.RunSynchronously
