namespace Library

open FSharp.Configuration

type Test = YamlConfig<"Test.yaml">

module M =
    let value = Test().Section1.Value1
