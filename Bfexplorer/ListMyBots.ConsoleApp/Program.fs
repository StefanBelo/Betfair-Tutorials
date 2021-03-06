(*
    Markdown format used:

    https://guides.github.com/features/mastering-markdown/

    Name of the bot: #
    Name of the parameter: ##
*)

open System
open System.ComponentModel.DataAnnotations
open System.IO

open BeloSoft.Data
open BeloSoft.Bfexplorer.Domain
open BeloSoft.Bfexplorer.Service

let rec listBotParameters (anObj : obj) (writer : StreamWriter) =
    let properties = 
        if anObj :? Type
        then
            (anObj :?> Type).GetProperties()
        else
            anObj.GetType().GetProperties()

    properties
    |> Array.iter (fun property -> 
            let customAttribute =
                let customAttributes = property.GetCustomAttributes(typeof<DisplayAttribute>, false)

                if customAttributes.Length > 0
                then
                    Some (customAttributes.[0] :?> DisplayAttribute)
                else
                    None

            customAttribute
            |> Option.iter (fun customAttribute ->                    
                    if isNullObj customAttribute.Description
                    then
                        writer.WriteLine($"### {property.Name}")
                        writer |> listBotParameters property.PropertyType
                    else
                        writer.WriteLine($"##### {property.Name}")
                        writer.WriteLine(customAttribute.Description)
                )
        )

[<EntryPoint>]
let main argv =
    let bfexplorerService = BfexplorerService(initializeBotManager = true)

    let myBots = bfexplorerService.BotManager.MyBots

    let filePathName =
        if argv.Length = 1
        then
            Path.Combine(argv.[0], "MyBots.md")
        else
            @"..\..\..\Output\MyBots.md"
    
    try
        use writer = File.CreateText(filePathName)

        myBots
        |> List.iter (fun boDesriptor -> 
                let botName = boDesriptor.BotId.Name

                writer.WriteLine($"# {botName}")
                printfn "%s" botName

                writer |> listBotParameters boDesriptor.Parameters
            )

        printfn "Having %d betfair bots to execute." myBots.Length
    with
    | ex -> printf "Failed to generate the list of bots: %s" ex.Message

    0