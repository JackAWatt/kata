def find_message(text):
    """Find a secret message"""
    text = list(text)
    message = ""
    for x in text:
        if x.isupper():
            message += x
    return message
