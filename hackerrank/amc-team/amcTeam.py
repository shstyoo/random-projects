# Given a list of N people who are attending and given that each person
# can only know one topic, calculate the maximum number of topics a 2 person
# team can know. Also find how many teams can know that maximum number of
# topics. N = #ofpeople, M = #oftopics. The matrix is either 1 or 0 depending
# on whether or not the person knows the topic

# https://www.hackerrank.com/challenges/acm-icpc-team

# The work you see here is highly derivative of code written by u/SigmaSquared
# in the discussion section of this particular hackerrank problem. In addition,
# u/omalsa04 also helped to understand exactly what was going on in the line:
# combintedTopics=bin(topic[p1]|topic[p2]).count('1')
# where you count the number of 1's in a binary number to see the maximum number
# of topics a team of 2 can know.

import sys
import itertools

n,m = input().strip().split(' ')
n,m = [int(n),int(m)]
topic = []
topic_i = 0

# This initial for loop reads in the input, and parses it as an int()
for topic_i in range(n):
    topic_t = int(input(),2)
    topic.append(topic_t)
# mxTopic is the max number of topics any team can know (set to zero at first)
mxTopic = 0
# numTeam designates the number of teams that know the maximum number of topics (set at zero)
numTeam = 0
# p1,p2 are the combinations from the number of people given in the dataset
for p1,p2 in itertools.combinations(range(n),2):
    # the addition of the two lines we are comparing (for example: [1 0 1 0 1] & [1 1 1 0 0] turns into [1 1 1 0 1])
    # we then count the number of 1's in the line giving us the maximum number of topics a team can have
    combinedTopics=bin(topic[p1]|topic[p2]).count('1')
    # if the number of combinedTopics in a certain 2 person team is equal to the current maximum number of topics
    if(combinedTopics==mxTopic):
        # add another count to the numTeam that know the maximum number of topics
        numTeam+=1
    # if the number of combinedTopics in a certain 2 person team is greater than the current maximum number of topics
    elif(combinedTopics>mxTopic):
        # set the new mxTopic to be equal to the combintedTopics
        mxTopic = combinedTopics
        # set the number of teams that know the mxTopic to be 1
        numTeam=1
# print the number of topics, and the number of teams that know the max topics separated by a newline
print(mxTopic,numTeam,sep='\n')
