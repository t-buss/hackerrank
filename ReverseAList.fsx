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

let rev input =
    input
    |> Seq.zip [0..lines.Length]
    |> Seq.sortByDescending (fun (i,v) -> i)
    |> Seq.map (fun (_, value) -> value)

for x in lines |> rev do
    printfn "%d" x
