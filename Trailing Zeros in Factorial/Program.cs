int A = 24;

int count = 0;

int logOfA = (int)Math.Log(A, 5);

for (int i = 1; i <= logOfA; i++)
{
    count += (int)(A / Math.Pow(5, i));
}

return count;