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

let myFilter n seq =
    seq
    |> Seq.collect (fun it -> if it >= n then [] else [it])


for x in lines |> myFilter n do
    printfn "%d" x
