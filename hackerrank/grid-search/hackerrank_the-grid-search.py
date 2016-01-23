import sys

f = open('testcase.txt', 'r')
f_ = f.readline()
t = int(f_)
for a0 in range(t):
    R,C = f_.strip().split(' ')
    R,C = [int(R),int(C)]
    G = []
    G_i = 0
    print(a0)
    for G_i in range(R):
        G_t = str(f_.strip())
        G.append(G_t)
    r,c = f_.strip().split(' ')
    r,c = [int(r),int(c)]
    P = []
    P_i = 0
    for P_i in range(r):
        P_t = str(f_.strip())
        P.append(P_t)
