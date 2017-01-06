def index_power(array, n):
    """
        Find Nth power of the element with index N.
    """
    if n > len(array)-1:
        x = -1
    else:
        x = array[n]**n
    return x
