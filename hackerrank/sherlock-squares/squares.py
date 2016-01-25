# Given two integers, calculate the nubmer of integers that are squares of other integers between them (inclusive)
# Time complexity given extremely large integers may cause a problem with iterating through a loop using
# brute force to solve the issue. Using a more elegent solution, such as searching only for the square numbers
# may provide a better result. Or even searching through a list of square root numbers that are integers.

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
            counter += 1
    print(counter)
