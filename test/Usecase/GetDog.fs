namespace test

module Usecase =

    open Xunit
    open Src.Usecase.GetDog
    open Src.DIContainer
    open Src.Domain
    open FSharpPlus.Data

    [<Fact>]
    let ``犬が取得できること`` () =
        let mutable nCallsFindAllDogs = 0

        let findAllDogs _ =
            nCallsFindAllDogs <- nCallsFindAllDogs + 1
            [ { breed = "ポメちゃん" } ]

        let actual =
            { DIContainer.Default with
                FindAllDogs = findAllDogs }
            |> Reader.run (execute ())

        Assert.Equal(actual.breed, "ポメちゃん")
        Assert.Equal(nCallsFindAllDogs, 1)
