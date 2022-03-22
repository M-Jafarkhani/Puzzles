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
rectangles = [];

all_states = []
createAllTiles()
print(list(all_states))
fig = plt.figure()
ax = fig.add_subplot(111)
x = 0

for permutationState in all_states:
    for state in permutationState:
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
        x = x+4     
        
for tile in rectangles:
    ax.add_patch(tile)

plt.xlim([0, 10 * n])
plt.ylim([0, 10])

plt.show()
