## Intro

The goal of Breadth-First Search (BFS) is to systematically explore and visit all the vertices of a graph or tree in breadthward motion from a given source vertex. BFS is an algorithm that traverses or searches through the graph level by level, visiting all the neighbors of a node before moving on to the next level.

## Pseudo Code

```
BFS(G,s)
for each vertex u in V[G] - {s}
    do color[u] <- white
        d[u] <- infinity
        pi <- NULL
color[s] <- Grey
d[s] <-0
pi[s] <- NULL
Q - emptu
enqueue(Q,s) // insert node to the Queue
    while Queue is not empty
        do u <- dequeue(Q) // working on the first node
            for each v in adj[u] // for each neighbor
            do if color[v] = white // if the neighbor was not visited so he is white
            then color[v] <- grey
                 d[v] <- d[u] + 1
                 pi[v] <- u
                enqueue(Q,v) // insert to the queue
            color[u] <- black
```

## Key goals and characteristics of BFS include:

1. Exploration of Levels: BFS explores the graph level by level, starting from the source vertex. It visits all vertices at the current level before moving on to the vertices at the next level.

2. Shortest Path: When applied to an unweighted graph, BFS can be used to find the shortest path from the source vertex to all other vertices. This is because, in the process of exploring the graph level by level, the algorithm naturally discovers the shortest paths.

3. Connected Components: BFS can be used to determine the connected components of an undirected graph. It identifies all the vertices that are reachable from the source vertex.

4. Cyclic Graphs: BFS can also be used to detect cycles in a graph. If, during the traversal, a previously visited (grey) node is encountered, it indicates the presence of a cycle.

5. Widest Path: In a network or flow problem where edges have capacities, BFS can be used to find the widest path from the source to the destination.

6. Maze Solving: BFS can be used to find the shortest path in a maze or grid, where each cell represents a vertex, and edges represent possible movements.
