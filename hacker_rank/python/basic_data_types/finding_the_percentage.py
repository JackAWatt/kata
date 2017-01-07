if __name__ == '__main__':
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()
    t = student_marks[query_name]
    total = 0
    for x in t:
        total += float(x)
    total /= len(t)
    print("%.2f" % round(total,2))
