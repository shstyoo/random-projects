import sys

# Need to make sure that at the EOF on list G, we don't go out of bounds for a runtime error

t = int(input().strip())
for a0 in range(t):
    R,C = input().strip().split(' ')
    R,C = [int(R),int(C)]
    G = []
    G_i = 0
    for G_i in range(R):
        G_t = str(input().strip())
        G.append(G_t)
    r,c = input().strip().split(' ')
    r,c = [int(r),int(c)]
    P = []
    P_i = 0
    for P_i in range(r):
        P_t = str(input().strip())
        P.append(P_t)
    # Algorithm Starts here
    list_ans = []
    for i in range(R):
        if(P[0] in G[i]):
            for j in range(C-c+1):
                if(P[0]==G[i][j:j+c]):
                    ans =1
                    for k in range(1,r):
                        if(R>i+k and P[k]==G[i+k][j:j+c]):
                            ans = ans+1
                    list_ans.append(ans)
    answer = [i for i in list_ans if i==r]
    if(len(answer)>0):
        print "YES"
    else:
        print "NO"

    # Other Algorithm
    # for line in G:
    #     i = 0
    #     while i < len(G):
    #         i2 = 0
    #         rcounter = 0
    #         if P[i2] in G[i]:
    #             i3 = i
    #             colPos = G[i3].find(P[i2])
    #             while i2 < len(P):
    #                 if P[i2] in G[i3]:
    #                     if colPos == G[i3].find(P[i2]):
    #                         rcounter += 1
    #                 if(G[i3].count(P[i2]) > 1):
    #                     G.remove(P[i2])
    #                     x = 0
    #                     while x < c:
    #                         G.insert(colPos + x, -1)
    #                     if P[i2] in G[i3]:
    #                         if colPos == G[i3].find(P[i2]):
    #                             rcounter += 1
    #                 i2 += 1
    #                 i3 += 1
    #                 if(i3 > len(G)):
    #                     break;
    #             if(rcounter == r):
    #                 break
    #         i += 1
    # if(rcounter == r):
    #     print("YES")
    # else:
    #     print("NO")
