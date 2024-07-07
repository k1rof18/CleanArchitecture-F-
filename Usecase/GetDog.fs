namespace Usecase

module GetDog =
    open Domain
    open Gateway
    open System


    let getRandomElement (list: 'a list) =
        if List.isEmpty list then
            failwith "The list is empty"
        else
            let random = Random()
            let index = random.Next(0, List.length list)
            list.[index]

    let execute () : Dog =
        let dogs = Dog.findAll ()
        getRandomElement dogs
