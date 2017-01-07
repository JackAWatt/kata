def left_join(phrases):
    output = ""
    for x in phrases:
        output += x + ','
    phrases = list(output)
    del phrases[-1]
    output = ""
    for x in phrases:
      output += x
    output = output.replace("right","left")
    return output
