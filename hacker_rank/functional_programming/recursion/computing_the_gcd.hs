module Main where


gcd' :: Integral a => a -> a -> a
gcd'0 0 = undefined
gcd' a 0 = abs a
gcd' 0 b = abs b 
gcd' a b | a < b = gcd' b a
gcd' a b | a > b = gcd' b (rem a b)
-- This part is related to the Input/Output and can be used as it is
-- Do not modify it
main = do
  input <- getLine
  print . uncurry gcd' . listToTuple . convertToInt . words $ input
 where
  listToTuple (x:xs:_) = (x,xs)
  convertToInt = map (read :: String -> Int)
