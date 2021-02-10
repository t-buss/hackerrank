let sum =
    fsi.CommandLineArgs
    |> Seq.skip 1 // First argument is script's name
    |> Seq.sumBy (function x -> int x)

printfn $"{sum}"
