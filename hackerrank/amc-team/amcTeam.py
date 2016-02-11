# # Given a list of N people who are attending and given that each person
# can only know one topic, calculate the maximum number of topics a 2 person
# team can know. Also find how many teams can know that maximum number of
# topics. N = #ofpeople, M = #oftopics. The matrix is either 1 or 0 depending
# on whether or not the person knows the topic

# https://www.hackerrank.com/challenges/acm-icpc-team

import sys

n,m = input().strip().split(' ')
n,m = [int(n),int(m)]
topic = []
topic_i = 0
for topic_i in range(n):
    topic_t = str(input().strip())
    topic.append(topic_t)
    # Algorithm starts here
for i in range(n):
    for j in range(m):
        for k in range(n+1):
            if(topic[i][m] + topic[i][k] > 1):
                # Add in the requisite for two people, or one person knowing a topic in this combo
                # Some good shit
