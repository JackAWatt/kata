def checkio(data):
    li = []
    #Your code here
    #It's main function. Don't remove this function
    #It's used for auto-testing and must return a result for check.  
    for i,x in enumerate(data):
        if data.count(x) < 2:
            li.append(i)
    li.reverse()
    for i in li:
        del data[i]
        
    #replace this for solution
    return data
