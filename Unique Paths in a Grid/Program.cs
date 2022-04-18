List<List<int>> A = new List<List<int>>();
if (A.Count == 0)
{
    return 0;
}

int m = A.Count(), n = A[0].Count();

if (m == 1 && n == 1 && A[0][0] == 0)
{
    return 1;
}

if (A[m - 1][n - 1] == 1 || A[0][0] == 1)
{
    return 0;
}

int[,] pathsCount = new int[m, n];

pathsCount[0, 0] = 1;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (A[i][j] == 0)
        {
            if (i > 0 && A[i - 1][j] == 0 && j > 0 && A[i][j - 1] == 0)
            {
                pathsCount[i, j] = pathsCount[i - 1, j] + pathsCount[i, j - 1];
            }
            else if (j > 0 && A[i][j - 1] == 0)
            {
                pathsCount[i, j] = pathsCount[i, j - 1];
            }
            else if (i > 0 && A[i - 1][j] == 0)
            {
                pathsCount[i, j] = pathsCount[i - 1, j];
            }
        }
    }
}

return pathsCount[m - 1, n - 1];
