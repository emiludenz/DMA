let rec cfrac2float (lst:int list) : float =
    match lst with
    | [] -> System.Double.MaxValue
    | _ -> float lst.Head + 1./ float (cfrac2float lst.Tail)

let q0 = [3;4;12;4]
let q1 = [3;1;4;5]
let q2 = [3;0]

printfn "%f" (cfrac2float q0)
printfn "%f" (cfrac2float q1)
printfn "%f" (cfrac2float q2)