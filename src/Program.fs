namespace src

module Program =
    open Microsoft.AspNetCore.Builder
    open System
    open Src.DIContainer
    open Microsoft.AspNetCore.Http
    open Src.Controller.System
    open Src.Controller.Dog
    open FSharpPlus.Data
    open System.Threading.Tasks
    open Src.DIContainer.DIContainer

    let exitCode = 0

    [<EntryPoint>]
    let main args =
        let builder = WebApplication.CreateBuilder(args)
        let app = builder.Build()

        app.MapGet("/ping", Func<IResult> ping) |> ignore

        // ランダムに犬種が返されるエンドポイント
        app.MapGet("/dog", Func<IResult>(fun () -> newDIContainer |> Reader.run controller))
        |> ignore

        app.Run()
        exitCode
