let rec float2cfrac (x:float) =
  let q = int(x)
  let r = x - float(q)
  if r < 0.00000000001 then  //funktionen når aldrig et reelt 0.0, vi har derfor defineret et nulpunkt som værende et meget lille tal.
    []
  else
    q :: (float2cfrac (1.0/r))
printfn "Testing float2cfrac"
printfn "%A" (float2cfrac 3.245)
printfn "%A" (float2cfrac 3.0)
printfn "%A" (float2cfrac 3.14)
/// The following numbers "3.141" and "3.14134" will fail with this error 
/// message
/// error FS0193: internal error: Object reference not set to an instance of an object
///printfn "%A" (float2cfrac 3.1415)
///printfn "%A" (float2cfrac 3.14134)
/// It might be anything more then three decimals is not accepted

// The following number will execute properly
printfn "%A" (float2cfrac 3.141)




let rec _float2cfrac (x:float) : int list =
  let r = x - floor x
  if (x = floor x) then [int x] else
  match r with
  | r when r < 0.000000001 -> []
  | _ -> int x :: _float2cfrac (1./r)
printfn "Testing _float2cfrac"
printfn "%A" (_float2cfrac 3.245)

// returns [3]
printfn "%A" (_float2cfrac 3.0)
printfn "%A" (_float2cfrac 3.14)
// The following number will also execute properly
printfn "%A" (_float2cfrac 3.141)
// The following number will NOT fail with the error message as float2cfrac
printfn "%A" (_float2cfrac 3.1415)

