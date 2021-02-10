open System

let n = Console.ReadLine() |> int

let lines =
    seq { while true do yield Console.ReadLine() }
    |> Seq.takeWhile
        (function
        | line ->
            match Int32.TryParse line with
            | (true, _) -> true
            | (false, _) -> false)
    |> Seq.map Int32.Parse

let repeated n input =
    input |> Seq.collect (fun x -> Seq.replicate n x)

for x in lines |> repeated n do
    printfn "%d" x
