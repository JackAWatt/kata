module Main where

fib 0 = 1
fib 1 = 0
fib n = fib (n - 1) + fib (n - 2) 
-- Enter your code here to complete this function


-- This part is related to the Input/Output and can be used as it is
-- Do not modify it
main = do
    input <- getLine
    print . fib . (read :: String -> Int) $ input
