import sys

# Need to save current column buffer to make sure we get all the test cases
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
    for line in G:
        i = 0
        while i < len(G):
            i2 = 0
            rcounter = 0
            if P[i2] in G[i]:
                while i2 < len(P):
                    if P[i2] in G[i]:
                        rcounter += 1
                    i2 += 1
                    i += 1
                if(rcounter == r):
                    break
            i += 1
    if(rcounter == r):
        print("YES")
    else:
        print("NO")
