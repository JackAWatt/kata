#!/bin/python3

import sys
same_x = True
same_y = True
initial_x = ""
initial_y = ""

n = int(input().strip())
for a0 in range(n):
    x,y = input().strip().split(' ')
    x,y = [int(x),int(y)]
    if a0 == 0:
        initial_x = x
        initial_y = y
    else:
        if x != initial_x:
            same_x = False
        if y != initial_y:
            same_y = False


if same_x or same_y:
    out = "YES"
else:
    out = "NO"
print(out)
