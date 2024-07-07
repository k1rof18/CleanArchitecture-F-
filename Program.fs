namespace CleanArchitecture

module Program =
    open Microsoft.AspNetCore.Builder
    open System
    open Microsoft.AspNetCore.Http

    let exitCode = 0

    [<EntryPoint>]
    let main args =
        let builder = WebApplication.CreateBuilder(args)
        let app = builder.Build()

        app.MapGet("/ping", Func<IResult> Controller.System.ping)

        // ランダムに犬種が返されるエンドポイントを作成する
        app.MapGet("/dog", Func<IResult> Controller.Dog.controller)

        app.Run()
        exitCode
