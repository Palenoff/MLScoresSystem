#Copyright (c) 2018 Oleg Anshakov

def Include(k,O,L):
    Ext=0; Int=1
    for i in range(len(L)):
        if L[i][Int]<=O[k]:
            L[i][Ext]|={k}
        else:
            z=L[i][Int]&O[k]
            if {m for m in range(k) if m not in L[i][Ext] and O[m]>=z}==set():
                L.append([L[i][Ext]|{k},z])
    if {m for m in range(k) if O[m]>=O[k]}==set():
        L.append([{k},O[k]])

def Norris(O):
    L=[]
    for k in range(len(O)):
        Include(k,O,L)
    return L



    



        
