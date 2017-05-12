// https://liangwu.wordpress.com/2010/07/17/the-basic-of-recursive-function-in-f/
let rec factorial n =
     if n = 0 then 1
     else
        n * factorial (n - 1)

// a is the accumulator, no reason to pass in the 1 here, but it just makes things simple for learning.
let rec factorialFast n a =
    if n = 0 then a
    else
       factorialFast (n - 1) (n * a)

factorial 5
factorialFast 5 1