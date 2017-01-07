if __name__ == '__main__':
    N = int(input())
    command = ""
    li = []
    for x in range(N):
        command = str(input())
        command = command.split(" ")
        if command[0] == 'insert':
            li.insert(int(command[1]),int(command[2]))
        elif command[0] == 'print':
            print(li)
        elif command[0] == 'sort':
            li.sort()
        elif command[0] == 'pop':
            li.pop()
        elif command[0] == 'reverse':
            li.reverse()
        elif command[0] == 'append':
            li.append(int(command[1]))
        elif command[0] == 'remove':
            li.remove(int(command[1]))
