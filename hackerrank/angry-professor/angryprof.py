import sys

t = int(input().strip())
for a0 in range(t):
    n,k = input().strip().split(' ')
    n,k = [int(n),int(k)]
    a = [int(a_temp) for a_temp in input().strip().split(' ')]
    # Algorithm starts here
    late = 0
    cancel = False
    for item in a:
        if(item > 0):
            late += 1
        if(late > (n-k)):
            cancel = True
            break
    if(cancel == True):
        print("YES")
    else:
        print("NO")
