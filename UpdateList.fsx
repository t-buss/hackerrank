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


let absolutes arr = arr |> Seq.map (fun x -> if x < 0 then -x else x)

for x in lines |> absolutes do
    printfn "%d" x