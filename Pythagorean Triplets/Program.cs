using System.Collections;

Hashtable squares = new Hashtable();

int A = 10;

generateSquares(A);

var count = 0;

for (int i = 2; i < A; i++)
{
    for (int j = i; j < A; j++)
    {
        if (squares.Contains(Math.Pow(i, 2) + Math.Pow(j, 2)))
        {
            count++;
        }
    }
}

return count;

void generateSquares(int n)
{
    for (int i = 1; i <= n; i++)
    {
        squares.Add(Math.Pow(i, 2), i);
    }
}

