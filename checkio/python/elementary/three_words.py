def three_in_a_row(words):
    w = words.split()
    in_a_row = 0
    for x in w:
        if x.isnumeric():
            in_a_row = 0
        else:
            in_a_row += 1
        if in_a_row > 2:
            return True
        
    return False
