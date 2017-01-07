def string_multiplication(number):
    number = str(number)
    number = list(number)
    total = 1
    for x in number:
        if int(x) != 0:
            total *= int(x)
