namespace Controller

module System =
    open Microsoft.AspNetCore.Http
    type PingResponse = { pong: bool }
    let ping () : IResult = Results.Ok { pong = true }
