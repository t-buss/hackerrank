// https://mathopenref.com/coordpolygonarea.html

open System

let n = Console.ReadLine() |> int

let coords =
    stdin.ReadToEnd().Split "\n"
    |> Seq.map (fun str -> str.Trim())
    |> Seq.filter (fun str -> str <> "")
    |> Seq.map ( (fun x -> x.Split " ") >> (fun xs -> (int (xs.[0]), int (xs.[1]))))
    |> Seq.toList

let area (x1, y1) (x2, y2): int = (x1 * y2) - (y1 * x2)

let mutable sum = 0

for i in [ 0 .. n - 1 ] do
    sum <- sum + area coords.[i] coords.[(i + 1) % n]

printfn "%f" (Math.Abs(float (sum) / 2.0))
