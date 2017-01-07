def swap_case(s):
    li = ""
    for x in list(s):
        if x.isupper():
            li = li + x.lower()
        elif x.islower():
            li = li + x.upper()
        else:
            li = li + x
        
    return li
