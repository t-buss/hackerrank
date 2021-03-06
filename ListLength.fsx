open System

let lines =
    seq { while true do yield Console.ReadLine() }
    |> Seq.takeWhile
        (function
        | line ->
            match Int32.TryParse line with
            | (true, _) -> true
            | (false, _) -> false)
    |> Seq.map Int32.Parse
    |> List.ofSeq

let length arr =
    Seq.sumBy (fun _ -> 1) arr

printfn "%d" (length lines)