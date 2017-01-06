def fizz_buzz(number):
    if number % 3 == 0 and number % 5 == 0:
        x = "Fizz Buzz"
    elif number % 3 == 0:
        x = "Fizz"
    elif number % 5 == 0:
        x = "Buzz"
    else:
        x = str(number)
            
    return x
