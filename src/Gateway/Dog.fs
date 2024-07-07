namespace Src.Gateway

open Src.Domain
open Src.Driver.InMemoryDB
open Src.Port.Dog

module Dog =
    let findAll () : FindAll =
        fun (_) ->
            let res = Dogs.ListDogs() |> List.map (fun x -> { breed = x })
            res
