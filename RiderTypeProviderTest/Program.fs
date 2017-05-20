open Library

[<EntryPoint>]
let main argv = 
    let yamlValue = YamlTest().Section1.Value1
    let jsonValue = JsonTest.Parse("").F1
    printfn "%A" argv
    0
