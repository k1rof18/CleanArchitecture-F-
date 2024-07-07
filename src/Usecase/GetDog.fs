namespace Src.Usecase

module GetDog =
    open Src.Gateway
    open System
    open FSharpPlus
    open FSharpPlus.Data
    open Src.DIContainer
    open Src.Domain

    let getRandomElement (list: 'a list) =
        if List.isEmpty list then
            failwith "The list is empty"
        else
            let random = Random()
            let index = random.Next(0, List.length list)
            list.[index]

    let execute () : Reader<DIContainer, Dog> =
        monad {
            let! env = ask
            let dogs = env.FindAllDogs ""
            getRandomElement dogs
        }
