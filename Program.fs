namespace CleanArchitecture

module Program =
    open Microsoft.AspNetCore.Builder
    open System
    open Microsoft.AspNetCore.Http

    let exitCode = 0

    type PingResponse = { pong: bool }

    [<EntryPoint>]
    let main args =
        let builder = WebApplication.CreateBuilder(args)
        let app = builder.Build()


        let ping () : IResult = Results.Ok { pong = false }

        app.MapGet("/ping", Func<IResult> ping)

        app.Run()
        exitCode
