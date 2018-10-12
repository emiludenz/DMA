let rec frac2cfrac (t:int)(n:int) =
  if n = 0 then []
  else t/n :: frac2cfrac n (t%n)

printfn "%A" (frac2cfrac 649 200)
printfn "%A" (frac2cfrac 628 200)
printfn "%A" (frac2cfrac 6 2)
printfn "%A" (frac2cfrac 6 0)


let rec _frac2cfrac (t:int) (n:int) : int list =
  match n with 
  | 0 -> []
  | _-> t/n :: _frac2cfrac n (t%n)

printfn "%A" (_frac2cfrac 649 200)
printfn "%A" (_frac2cfrac 628 200)
printfn "%A" (_frac2cfrac 6 2)
printfn "%A" (_frac2cfrac 6 0)

