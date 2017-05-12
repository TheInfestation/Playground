let fizzBuzz x =
    match x with
    | _ when x % 15 = 0 -> "FizzBuzz"
    | _ when x % 3 = 0 -> "Fizz"
    | _ when x % 5 = 0 -> "Buzz"
    | _ -> x.ToString()

[1..100]
|> List.map fizzBuzz
|> List.iter (printfn "%s")