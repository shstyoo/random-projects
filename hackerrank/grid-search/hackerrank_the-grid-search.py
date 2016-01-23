import sys

# Open up file
f = open('testcase.txt', 'r')

# Instantiate List
f_ = []

# Iterate for line in file, insert into list from 0 -> EOF
for line in f:
    f_.insert(len(f_), line)
