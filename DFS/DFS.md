# Pseudo code

```
DFS(graph, start_node, visited):
    if start_node is not visited:
        mark start_node as visited
        process(start_node)  // Do something with the node

        for each neighbor in neighbors of start_node:
            if neighbor is not visited:
                DFS(graph, neighbor, visited)
```

```
For each vertex u in V[G]
    do color[u] <- white
          pi[u] <- Null
    time <- 0
For each vertex u in V[G]
    do if color[u] = white
        then DFS-Visit(u)

DFS-Visit(u)
    color[u] <- grey
    time <- time + 1
    d[u] <- time
    for each v in adj[u] // list of adjenscy
        do if color[v] = white
            then pi[v] <- u
                DFS-Visit(v)
        color[u] <- black
        f[u]<- time <- time +1
```

# 1. Limititions

While Depth-First Search (DFS) is a powerful algorithm for traversing graphs, it does have some limitations and considerations:

## 2. Completeness:

1.DFS may not find a solution in an infinite graph. If the graph is infinite and the solution is at an unreachable location, DFS will continue indefinitely.

## 3. Non-Optimality:

DFS doesn't guarantee finding the shortest path. It might find a path with more edges before finding a shorter path.

## 4. Space Complexity:

In the worst case, DFS has a space complexity of O(bd) where b is the branching factor and d is the depth of the deepest path. This can be an issue for large graphs or graphs with deep paths.

## 5. Disconnected Graphs:

In the case of a disconnected graph, DFS may not visit all nodes. If you want to ensure that all nodes are visited, you might need to run DFS from multiple starting points.

## 6. Time Complexity:

In the worst case, DFS can take O(V + E) time, where V is the number of vertices and E is the number of edges. This is because it may visit all vertices and edges.

## 7. Memory Stack Overflow:

For very deep graphs, DFS can lead to a stack overflow due to excessive recursion. In practice, this can be mitigated by using an iterative approach or increasing the stack size.

## 8. Not Ideal for Finding Shortest Path:

DFS is not the best choice if you specifically need to find the shortest path in weighted graphs. Algorithms like Dijkstra's or A\* are more suitable for such scenarios.

## 9. Edge Classification:

DFS doesn't explicitly distinguish between different types of edges (tree edges, back edges, forward edges, and cross edges). If such distinctions are crucial for your application, you might need to use other algorithms like Tarjan's algorithm.

Despite these limitations, DFS is a versatile algorithm widely used in various applications such as topological sorting, connected components, and solving puzzles. Understanding its strengths and weaknesses is crucial for choosing the right algorithm for a specific problem.
