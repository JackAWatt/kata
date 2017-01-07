if __name__ == '__main__':
    n = int(input())
    arr = input().split()
    for i,x in enumerate(arr):
        arr[i] = int(x)
    arr = list(set(arr))
    arr.sort()
    print(arr[-2])
