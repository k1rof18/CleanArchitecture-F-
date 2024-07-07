namespace Controller

module Dog =
    open Microsoft.AspNetCore.Http
    type Response = { Breed: string }

    let controller () = Results.Ok { Breed = "Pomeranian" }
