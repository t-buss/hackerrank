open System

let t = Console.ReadLine() |> int

let valid pairs =
    pairs |>
    Seq.groupBy (fun (x, y) -> x)
    |> Seq.map (fun (key, list) -> Seq.length list)
    |> Seq.tryFind (fun length -> length > 1)
    |> Option.isNone

let result =
    [ 1 .. t ]
    |> Seq.map (fun _ ->
            let n = Console.ReadLine() |> int
            let pairs =
                [ 1 .. n ]
                |> Seq.map (fun _ -> Console.ReadLine().Split " ")
                |> Seq.map (fun strArr -> strArr.[0], strArr.[1])
            valid pairs)

for r in result do
    if r then
        printfn "YES"
    else
        printfn "NO"
