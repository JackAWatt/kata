def verify_anagrams(first_word, second_word):
    first_word = first_word.strip(" ")
    second_word = second_word.strip(" ")
    first_word = first_word.lower()
    second_word = second_word.lower()
    print(first_word)
    print(second_word)
    first_word = list(first_word)
    second_word = list(second_word)
    print(first_word)
    print(second_word)
    first_word.sort()
    second_word.sort()
    first_word = "".join(first_word)
    second_word = "".join(second_word)
    print(len(list(first_word)))
    print(len(list(second_word)))
    if (first_word.strip(" ") == second_word.strip(" ")):
        return True
    return False

if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
    assert isinstance(verify_anagrams("a", 'z'), bool), "Boolean!"
    assert verify_anagrams("Programming", "Gram Ring Mop") == True, "Gram of code"
    assert verify_anagrams("Hello", "Ole Oh") == False, "Hello! Ole Oh!"
    assert verify_anagrams("Kyoto", "Tokyo") == True, "The global warming crisis of 3002"

