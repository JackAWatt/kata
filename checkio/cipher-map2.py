def recall_password(cipher_grille, ciphered_password):
    print(ciphered_password)
    rotated = zip(*ciphered_password[::-1])
    print(ciphered_password[1][1])


#if __name__ == '__main__':
    #These "asserts" using only for self-checking and not necessary for auto-testing
#    assert
recall_password(
        ('X...',
         '..X.',
         'X..X',
         '....'),
        ('itdf',
         'gdce',
         'aton',
         'qrdi')) == 'icantforgetiddqd', 'First example'
#
#    assert recall_password(
#        ('....',
#         'X..X',
#         '.X..',
#         '...X'),
#        ('xhwc',
#         'rsqx',
#         'xqzz',
#         'fyzr')) == 'rxqrwsfzxqxzhczy', 'Second example'
