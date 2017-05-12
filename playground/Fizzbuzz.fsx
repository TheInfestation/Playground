let fizzBuzz x =
    match x with
    | _ when (x % 15) = 0 -> "FizzBuzz"
    | _ when (x % 3) = 0 -> "Fizz"
    | _ when (x % 5) = 0 -> "Buzz"
    | _ -> x.ToString()

[1..100]
|> List.map (fun f -> fizzBuzz f)
|> List.iter (printfn "%s")

//Print the numbers from 1 to 100
//If the number is divisible by 3 print “Fizz” instead
//If the number is divisible by 5 print “Buzz” instead
//If the number is divisible 3 and 5 print “FizzBuzz” instead