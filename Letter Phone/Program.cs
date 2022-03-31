string A = "12301";

List<List<string>> map = new List<List<string>>()
        {
            new List<string>(){"0"},
            new List<string>(){"1"},
            new List<string>(){"a","b","c"},
            new List<string>(){"d","e","f"},
            new List<string>(){"g","h","i"},
            new List<string>(){"j","k","l"},
            new List<string>(){"m","n","o"},
            new List<string>(){"p","q","r","s"},
            new List<string>(){"t","u","v"},
            new List<string>(){"w","x","y","z"},
        };

var result = recursiveMerge(A);

return 1;

List<string> recursiveMerge(string S)
{
    List<string> result = new List<string>();

    if (S.Length == 1)
    {
        return map[(int)Char.GetNumericValue(S[0])];
    }
    else if (S.Length == 2)
    {
        return mergeList(map[(int)Char.GetNumericValue(S[0])], map[(int)Char.GetNumericValue(S[1])]);
    }
    else
    {
        return mergeList(map[(int)Char.GetNumericValue(S[0])], recursiveMerge(S.Remove(0, 1)));
    }
}

List<string> mergeList(List<string> A, List<string> B)
{
    List<string> result = new List<string>();

    for (int i = 0; i < A.Count; i++)
    {
        for (int j = 0; j < B.Count; j++)
        {
            result.Add($"{A[i]}{B[j]}");
        }
    }

    return result;
}