namespace Src.DIContainer

type DIContainer =
    { FindAllDogs: Src.Port.Dog.FindAll }

    static member Default: DIContainer =
        let unsupported () = failwith "Unsupported port"
        { FindAllDogs = fun _ -> unsupported () }

module DIContainer =
    let newDIContainer = { DIContainer.FindAllDogs = Src.Gateway.Dog.findAll () }
