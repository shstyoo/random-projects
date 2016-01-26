# Given two integers, calculate the nubmer of integers that are squares of other integers between them (inclusive)

# https://www.hackerrank.com/challenges/sherlock-and-squares

import sys

t = int(input().strip())
for a0 in range(t):
    n,k = input().strip().split(' ')
    n,k = [int(n),int(k)]
    # Algorithm starts here
    i = n
    counter = 0
    for i in range(n,k+1):
        i = i ** 0.5
        if(int(i) == i):
            while(True):
                x = i ** 2
                i += 1
                if(x > k):
                    break
                else:
                    counter += 1
            break
    print(counter)
