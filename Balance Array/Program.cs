List<int> A = new List<int>() { 1, 2, 3, 4, 5 };

if (A.Count == 2)
{
    return 0;
}

if (A.Count == 1)
{
    return 1;
}

int sumOfEvens = 0, sumOfOdds = 0, count = 0;

for (int i = 0; i < A.Count; i++)
{
    if (i % 2 == 0)
    {
        sumOfEvens += A[i];
    }
    else
    {
        sumOfOdds += A[i];
    }
}

for (int i = 0; i < A.Count; i++)
{
    if (i % 2 == 0)
    {
        if (sumOfEvens - A[i] == sumOfOdds)
        {
            count++;
        }

        sumOfOdds += A[i];

        sumOfEvens -= A[i];
    }
    else
    {
        if (sumOfOdds - A[i] == sumOfEvens)
        {
            count++;
        }

        sumOfOdds -= A[i];

        sumOfEvens += A[i];
    }
}

return count;
