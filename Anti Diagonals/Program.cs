List<List<int>> A = new List<List<int>>()
{
    new List<int>(){1,2,3},
    new List<int>(){4,5,6},
    new List<int>(){7,8,9}
};

var N = A.Count;

List<List<int>> result = new List<List<int>>();

for (int k = 0; k < 2 * N - 1; k++)
{
    List<int> current = new List<int>();

    if (k < N)
    {
        for (int i = 0, j = k; i <= k && j > -1; i++, j--)
        {
            current.Add(A[i][j]);
        }
    }
    else
    {
        for (int i = k - N + 1, j = N - 1; i < N && j > -1; i++, j--)
        {
            current.Add(A[i][j]);
        }
    }

    result.Add(current);
}

return 1;
