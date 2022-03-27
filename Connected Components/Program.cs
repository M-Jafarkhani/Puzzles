int A = 4;

List<List<int>> B = new List<List<int>>() { new List<int>() { 1,2}, new List<int>() { 2, 3 } };

int[] parent = new int[100001];

for (int i = 1; i <= A; i++)
{
    parent[i] = i;
}

for (int i = 0; i < B.Count; i++)
{
    connect(Math.Min(B[i][0], B[i][1]), Math.Max(B[i][0], B[i][1]));
}

var count = 0;

for (int i = 1; i <= A; i++)
{
    if (i == parent[i])
    {
        count++;
    }
}

return count;

int root(int a)
{
    if (a == parent[a])
    {
        return a;
    }

    parent[a] = root(parent[a]);

    return parent[a];
}

void connect(int a, int b)
{
    if (a == b)
    {
        return;
    }

    a = root(a);

    b = root(b);

    parent[Math.Max(a, b)] = Math.Min(a, b);
}

