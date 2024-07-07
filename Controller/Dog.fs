namespace Controller

module Dog =
    open Microsoft.AspNetCore.Http
    open Usecase.GetDog

    type Response = { Breed: string }

    let controller () =
        let x = execute ()
        Results.Ok { Breed = x.breed }
