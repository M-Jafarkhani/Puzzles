List<int> A = new List<int>() { 1, 2, 3 };

var result = recursivePermutation(A);

return 1;

List<List<int>> recursivePermutation(List<int> A)
{
    if (A.Count == 1)
    {
        return new List<List<int>>()
                {
                    new List<int>()
                    {
                        A[0]
                    }
                };
    }
    else if (A.Count == 2)
    {
        return new List<List<int>>()
                {
                    new List<int>()
                    {
                        A[0], A[1]
                    },
                    new List<int>()
                    {
                        A[1], A[0]
                    }
                };
    }
    else
    {
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < A.Count; i++)
        {
            var temp = A[i];

            A.RemoveAt(i);

            var tempResult = recursivePermutation(A);

            for (int j = 0; j < tempResult.Count; j++)
            {
                tempResult[j].Insert(0, temp);

                result.Add(tempResult[j]);
            }

            A.Insert(i, temp);
        }

        return result;
    }
}

