using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list representation

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void TopologicalSort()
    {
        Stack<int> stack = new Stack<int>();
        bool[] visited = new bool[V];

        for (int i = 0; i < V; ++i)
        {
            if (!visited[i])
                DfsEdited(i, visited, stack);
        }

        Console.WriteLine("Topological Sorting:");
        while (stack.Count > 0)
            Console.Write(stack.Pop() + " ");
    }

    private void DfsEdited(int v, bool[] visited, Stack<int> stack)
    {
        visited[v] = true;

        foreach (int i in adj[v])
        {
            if (!visited[i])
                DfsEdited(i, visited, stack);
        }

        stack.Push(v);
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(6);

        g.AddEdge(5, 2);
        g.AddEdge(5, 0);
        g.AddEdge(4, 0);
        g.AddEdge(4, 1);
        g.AddEdge(2, 3);
        g.AddEdge(3, 1);

        g.TopologicalSort();
    }
}
