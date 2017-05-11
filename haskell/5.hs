import Data.List
import System.IO

evenList = [2,4..20]

fac :: Int -> Int

fac 0 = 1
fac n =  n * fac (n -1)

weirdShit :: Char -> Int
weirdShit 'C' = 1
weirdShit _ = 0
