open System

let n = Console.ReadLine() |> int
let coords = 
    stdin.ReadToEnd().Split "\n"
    |> Array.map (fun str -> str.Trim() )
    |> Array.filter (fun str -> str <> "")
    |> Array.map (fun x -> x.Split " ")
    |> Array.map (fun xs -> (int(xs.[0]), int(xs.[1])))
    |> Array.toList

let distance (x1: int, y1: int) (x2: int, y2: int) =
    Math.Sqrt(float ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)))

let mutable sum = 0.0
for i in [0..n-1] do
    sum <- sum + distance coords.[i] coords.[(i+1)%n]

printfn "%f" sum
