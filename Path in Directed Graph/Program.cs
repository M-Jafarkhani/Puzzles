int A = 5;

List<List<int>> B = new List<List<int>>();

int maxEdge = 0;

foreach (var node in B)
{
    int currentMax = Math.Max(node[0], node[1]);

    if (currentMax > maxEdge)
    {
        maxEdge = currentMax;
    }
}

Graph graph = new Graph(maxEdge);

foreach (var node in B)
{
    graph.addEdge(node[0] - 1, node[1] - 1);
}

return graph.HasPath(A - 1) ? 1 : 0;

public class Graph
{
    private readonly int V;

    private readonly List<List<int>> adj;

    public Graph(int V)
    {
        this.V = V;

        adj = new List<List<int>>(V);

        for (int i = 0; i < V; i++)
            adj.Add(new List<int>());
    }

    private bool isAccessiable(int start, int end, bool[] visited, bool[] recStack)
    {
        if (start == end)
            return true;

        if (recStack[start])
            return true;

        if (visited[start])
            return false;

        visited[start] = true;

        recStack[start] = true;

        List<int> children = adj[start];

        foreach (int next in children)
            if (isAccessiable(next, end, visited, recStack))
                return true;

        recStack[start] = false;

        return false;
    }

    public void addEdge(int start, int end)
    {
        adj[start].Add(end);
    }

    public bool HasPath(int destination)
    {
        bool[] visited = new bool[V];

        bool[] recStack = new bool[V];

        return isAccessiable(0, destination, visited, recStack);
    }
}

