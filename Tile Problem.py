import matplotlib
import matplotlib.pyplot as plt
from itertools import permutations,combinations
import numpy as np

def createAllTiles():
    all_states.append(list(set(permutations(tiles,len(tiles)))))
    ones_count = np.bincount(tiles)[1]
    if(ones_count < 2):
        return
    tiles.remove(1)
    tiles.remove(1)
    tiles.append(2)
    createAllTiles()
            
n = 4;
tiles = [1] * n

all_states = []
createAllTiles()
t = np.arange(0, 2, 1)
fig, axs = plt.subplots(nrows=sum(len(row) for row in all_states), ncols=1,sharex = True,figsize=(10,n*10))
i = 0

for permutationState in all_states:
    for state in permutationState:
        rectangles = [];
        x = 0
        for tile in state:
            if (tile == 1):
                rectangles.append(matplotlib.patches.Rectangle((x, 0), 1, 2, 
                                                               edgecolor="black", facecolor="green", fill=True))
                x = x+1
            else:
                rectangles.append(matplotlib.patches.Rectangle((x, 0), 2, 1, 
                                                               edgecolor="black", facecolor="red", fill=True))
                rectangles.append(matplotlib.patches.Rectangle((x, 1), 2, 1, 
                                                               edgecolor="black", facecolor="red", fill=True))
                x = x+2 
        for rectangle in rectangles:
            axs[i].add_patch(rectangle)
            axs[i].set_xlim([0, n])
            axs[i].set_ylim([0, 2])
            axs[i].set_xlabel(state)
            axs[i].tick_params(left = False, right = False , labelleft = False ,
                labelbottom = False, bottom = False)
        i = i + 1
        
plt.show()
