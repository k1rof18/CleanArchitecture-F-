namespace Src.Controller

module Dog =
    open Microsoft.AspNetCore.Http
    open Src.Usecase.GetDog
    open FSharpPlus.Data
    open Src.DIContainer
    open System.Threading.Tasks

    type Response = { Breed: string }

    let controller: Reader<DIContainer, IResult> =
        execute () |> Reader.map ((fun x -> Results.Ok { Breed = x.breed }))
