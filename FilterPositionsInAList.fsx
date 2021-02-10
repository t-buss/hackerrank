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

let filterOddPositions input =
    input
    |> Seq.zip [1..lines.Length]
    |> Seq.filter (fun (index, _) -> index % 2 = 0)
    |> Seq.map (fun (_, value) -> value)

for x in lines |> filterOddPositions do
    printfn "%d" x
