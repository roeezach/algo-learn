using System;
using System.Collections.Generic;

enum NodeColor
{
    White, // Not visited
    Grey,  // Visited
    Black  // Finished (no neighbors)
}

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list representation
    private NodeColor[] nodeColors; // Color of nodes
    private int[] discTime; // Discovery time of nodes
    private int[] finishTime; // Finishing time of nodes
    private int time; // Timestamp

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();

        nodeColors = new NodeColor[v];
        discTime = new int[v];
        finishTime = new int[v];
        time = 0;
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void DFS(int startVertex)
    {
        InitializeColors();

        Stack<int> stack = new Stack<int>();
        stack.Push(startVertex);

        while (stack.Count > 0)
        {
            int v = stack.Pop();

            if (nodeColors[v] == NodeColor.White)
            {
                nodeColors[v] = NodeColor.Grey;
                discTime[v] = ++time;
                Console.WriteLine($"Node {v} discovered at timestamp {discTime[v]}");

                // Push adjacent vertices onto the stack
                foreach (int neighbor in adj[v])
                {
                    if (nodeColors[neighbor] == NodeColor.White)
                    {
                        stack.Push(neighbor);
                    }
                }
            }
            else if (nodeColors[v] == NodeColor.Grey)
            {
                nodeColors[v] = NodeColor.Black;
                finishTime[v] = ++time;
                Console.WriteLine($"Node {v} finished at timestamp {finishTime[v]}");
            }
        }
    }

    private void InitializeColors()
    {
        for (int i = 0; i < V; ++i)
        {
            nodeColors[i] = NodeColor.White;
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

        Console.WriteLine("Depth First Traversal (starting from vertex 2): ");
        g.DFS(2);
    }
}
