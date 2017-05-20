namespace Library

open FSharp.Configuration
open FSharp.Data

type YamlTest = YamlConfig<"Test.yaml">
type JsonTest = JsonProvider<"""{ "f1": 3 }""">

module M =
    let yaml = YamlTest().Section1.Value1
    let json = JsonTest.Parse("").F1


