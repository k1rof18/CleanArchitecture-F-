namespace Gateway

open Domain
open Driver.InMemoryDB

module Dog =

    let findAll () : Port.Dog.FindAll =
        let res = Dogs.ListDogs() |> List.map (fun x -> { breed = x })
        res
