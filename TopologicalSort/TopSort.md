# Pseudo Code

```
TopologicalSort(graph):
    stack = empty stack
    visited = empty set

    for each node in graph:
        if node is not in visited:
            DfsEdited(graph, node, visited, stack)

    print "Topological Sorting:"
    while stack is not empty:
        print stack.pop()

DfsEdited(graph, node, visited, stack):
    add node to visited set

    for each neighbor in neighbors of node:
        if neighbor is not in visited:
            DfsEdited(graph, neighbor, visited, stack)

    stack.push(node)

```

Certainly! Here are the limitations of topological sorting in Markdown format, numbered for clarity:

1. **Acyclic Graphs Only:**

   - Topological sorting can only be applied to Directed Acyclic Graphs (DAGs). If the graph has cycles, it cannot have a valid topological order.

2. **Single Valid Order:**

   - A graph may have more than one valid topological ordering. The algorithm does not guarantee a unique solution.

3. **Limited Applicability:**

   - Topological sorting is meaningful only for certain types of problems where a partial order exists among the nodes.

4. **Not Suitable for Undirected Graphs:**

   - The concept of topological order is specific to directed graphs. For undirected graphs, the notion of a topological order is not meaningful.

5. **Requires a DAG:**

   - If the graph is not a DAG, attempting to apply topological sorting may lead to incorrect results.

6. **Dependency Resolution:**

   - While topological sorting is useful for dependency resolution, it does not provide information about the nature or type of dependencies.

7. **Dynamic Graphs:**

   - If the graph is dynamic and edges are added or removed frequently, recalculating the topological order can be computationally expensive.

8. **Complexity:**

   - The time complexity of the topological sorting algorithm can be relatively high in certain cases, especially for large graphs.

9. **Edge Classification:**
   - Topological sorting does not explicitly distinguish between different types of edges (tree edges, back edges, forward edges, and cross edges).

These limitations highlight the specific scenarios in which topological sorting is applicable and the conditions that need to be met for the algorithm to produce meaningful results.
