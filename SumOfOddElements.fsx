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

let sumOfOdds numbers =
    numbers
    |> Seq.filter (fun x -> x % 2 <> 0)
    |> Seq.sum

printfn "%d" (sumOfOdds lines)