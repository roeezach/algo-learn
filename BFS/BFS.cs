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
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void BFS(int s)
    {
        // Mark all vertices(nodes) as white
        int[] color = new int[V];
        for (int i = 0; i < V; ++i)
        {
            color[i] = 0; // 0 represents white
        }

        // Create a queue for BFS
        Queue<int> queue = new Queue<int>();

        // Mark the current node as grey and enqueue it
        color[s] = 1; // 1 represents grey
        queue.Enqueue(s);

        while (queue.Count != 0)
        {
            // Dequeue a vertex from the queue and print it
            s = queue.Dequeue();
            Console.Write(s + " ");

            // Get all adjacent vertices of the dequeued vertex s
            foreach (int i in adj[s])
            {
                // If an adjacent vertex is white, mark it grey and enqueue it
                if (color[i] == 0)
                {
                    color[i] = 1;
                    queue.Enqueue(i);
                }
            }

            // Mark the current node as black after all its neighbors are processed
            color[s] = 2; // 2 represents black
        }
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(4);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        Console.WriteLine("Breadth First Traversal (starting from vertex 2): ");
        g.BFS(2);
    }
}
