solve :: Double -> Double
solve x = 1 + x + (x^2/2) + (x^3/6) + (x^4/24) + (x^5/120) + (x^6/720) + (x^7/5040) + (x^8/40320) + (x^9/362880) -- + (x^10/3628800)-- Insert your code here --

main :: IO ()
main = getContents >>= mapM_ print. map solve. map (read::String->Double). tail. words
