open System

type Soldier = int
type Army =  Soldier list

type Event =
    | FindStrongest of int
    | StrongestDied of int
    | Recruit of int * int
    | Merge of int * int
    | UndefinedEvent

let mapEvents = 
    Seq.map ((function (str: string) -> str.Split " " |> Array.map int) >> (fun arr ->
            match arr.[0] with
            | 1 -> FindStrongest(arr.[1])
            | 2 -> StrongestDied(arr.[1])
            | 3 -> Recruit(arr.[1], arr.[2])
            | 4 -> Merge(arr.[1], arr.[2])
            | _ -> UndefinedEvent)) 

let firstLine = Console.ReadLine().Split " "
let n, q = int (firstLine.[0]), int (firstLine.[1])
let events = mapEvents (stdin.ReadToEnd().Split "\n")


let armies = Array.create n Army.Empty