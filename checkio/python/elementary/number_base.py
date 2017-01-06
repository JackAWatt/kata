def number_base(str_number, radix):
    try:
        x = int(str_number,radix)
    except ValueError:
        x = -1
    return x
