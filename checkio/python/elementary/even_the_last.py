def checkio(array):
    """
        sums even-indexes elements and multiply at the last
    """
    even_total = 0
    for i , x in enumerate(array):
        if i % 2 == 0:
            even_total += x
    
    if len(array) > 0:
        even_total *= array[len(array)-1]
    return even_total
