# # Given a square matrix of size N x N calculate the absolute difference between
# the sums of its diagonals

# https://www.hackerrank.com/challenges/diagonal-difference

import sys

n = int(input().strip())
a = []
for a_i in range(n):
    a_t = [int(a_temp) for a_temp in input().strip().split(' ')]
    a.append(a_t)
    # Algorithm starts here
    
