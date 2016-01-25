# Simple challenge that requires you to change the time (from its given 12HR format into a 24HR format)

# https://www.hackerrank.com/challenges/time-conversion

import sys

time = input().strip()

t = []

t = time.split(":")

if "PM" in time:
    if(int(t[0]) == 12):
        t[0] = "12"
    else:
        t[0] = int(t[0]) + 12
    t[2] = t[2].replace("PM", "")
else:
    if(int(t[0]) == 12):
        t[0] = "00"
    t[2] = t[2].replace("AM", "")

print(t[0], end="")
print(":", end="")
print(t[1], end="")
print(":", end="")
print(t[2], end="")
