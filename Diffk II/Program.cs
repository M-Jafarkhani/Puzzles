using System.Collections;

List<int> A = new List<int>();

int B = 0;

Hashtable hash = new Hashtable();

for (int i = 0; i < A.Count; i++)
{
    if (!hash.Contains(B + A[i]))
    {
        hash.Add(B + A[i], i);
    }
}

for (int i = 0; i < A.Count; i++)
{
    if (hash.Contains(A[i]) && (int)hash[A[i]] != i)
    {
        return 1;
    }
}

return 0;
