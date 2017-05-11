import Data.List
import System.IO
evenList = [2,4..20]


main = do
	putStrLn "What's your name?"
	name <- getLine
	putStrLn ("Hello " ++ name)
        main




addMe :: Int -> Int -> Int
addMe x y = x + y


thingWithStuff :: Int -> Int
thingWithStuff 42 = 1
thingWithStuff 7 = 0
thingWithStuff 2 = 2
thingWithStuff _ = 42 

factorial :: Int -> Int

factorial 0 = 1
factorial n = n * factorial (n - 1)

isOdd n
    | mod n 2 == 0 = False
    | otherwise = True

doStuff :: Int -> Int
doStuff (-1) = 1
doStuff 0 = 0
doStuff n  = n + doStuff (n-1)
