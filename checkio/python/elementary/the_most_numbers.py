def distance(*args):
    if args:
        min = args[0]
        max = args[0]
        for x in args:
            if x < min:
                min = x
            if x > max:
                max = x
    else:
        min = 0
        max = 0
    return max - min
