
int M = 0, N = 0;

int[,] cost;

List<List<int>> A = new List<List<int>>();

M = A.Count();

N = A[0].Count();

cost = new int[M, N];

return minPath(A, 0, 0);


int minPath(List<List<int>> A, int i, int j)
{
    if (cost[i, j] != 0)
    {
        return cost[i, j];
    }

    if (i == M - 1 && j == N - 1)
    {
        cost[i, j] = A[i][j];
    }
    else if (i == M - 1)
    {
        cost[i, j] = A[i][j] + minPath(A, i, j + 1);
    }
    else if (j == N - 1)
    {
        cost[i, j] = A[i][j] + minPath(A, i + 1, j);
    }
    else
    {
        cost[i, j] = A[i][j] + Math.Min(minPath(A, i + 1, j), minPath(A, i, j + 1));
    }

    return cost[i, j];
}