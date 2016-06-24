open System
open System.IO
open System.Numerics

[<Measure>] type degC
[<Measure>] type degF

let convertDegCToF c = 
    c * 1.8<degF/degC> + 32.0<degF>
       
let f = convertDegCToF 0.0<degC>    


module Temperature =
    type TemperatureType  = F of float | C of float

    let fold fahrenheitFunction celsiusFunction aTemp =
            match aTemp with
            | F f -> fahrenheitFunction f
            | C c -> celsiusFunction c

    let fConversion tempF =
        let convertedValue = (tempF - 32.0) / 1.8
        TemperatureType.C convertedValue    //wrapped in type

    let cConversion tempC =
        let convertedValue = (tempC * 1.8) + 32.0
        TemperatureType.F convertedValue    //wrapped in type

    // combine using the fold
//    let convert aTemp = Temperature.fold fConversion cConversion aTemp
    let temps() =   

        printfn "Enter the Fahrenheit temperature:"
        let input = Console.ReadLine() |> float 
        input
        |> fConversion
        |> printfn "%A"

        printfn "Enter the Celsius temperature:"
        let input = Console.ReadLine() |> float 
        input
        |> cConversion
        |> printfn "%A"
    temps()

     
//| degC -> (fun f -> c) |> String.Concat |> printfn "%A"
//-> printfn "%g" input 

[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

