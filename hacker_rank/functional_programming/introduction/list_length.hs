--Only fill up the blanks for the function named len
--Do not modify the structure of the template in any other way
len :: [a] -> Int
len lst = (maximum[i | (i, j) <- zip[1..] lst,odd i] +1)
