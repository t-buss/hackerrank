open System

let n = Console.ReadLine() |> int

let input =
    stdin.ReadToEnd().Split "\n"
    |> Array.map (fun x -> float (x))
    |> Array.toList

let rec factorial =
    function
    | x when x = 0 -> 1
    | x -> x * factorial (x - 1)

let eStep (x: float) (n: int): float = Math.Pow(x, float (n)) / float(factorial n)

let e (x: decimal) =
    1.0m + x
    + (Math.Pow(x, decimal(2)) )/ decimal(factorial 2)
    + (Math.Pow(x, decimal(3)) )/ decimal(factorial 3)
    + (Math.Pow(x, decimal(4)) )/ decimal(factorial 4)
    + (Math.Pow(x, decimal(5)) )/ decimal(factorial 5)
    + (Math.Pow(x, decimal(6)) )/ decimal(factorial 6)
    + (Math.Pow(x, decimal(7)) )/ decimal(factorial 7)
    + (Math.Pow(x, decimal(8)) )/ decimal(factorial 8)
    + (Math.Pow(x, decimal(9)) )/ decimal(factorial 9)
    + (Math.Pow(x, decimal(10)))/ decimal(factorial 10)

for x in (input |> Seq.map e) do
    printfn "%f" x
