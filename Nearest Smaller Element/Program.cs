List<int> A = new List<int>() { 4, 5, 2, 10, 8 };

var stack = new Stack<int>();

List<int> result = new List<int>();

for (int i = 0; i < A.Count; i++)
{
    while (stack.Count != 0 && stack.Peek() >= A[i])
    {
        stack.Pop();
    }
    if (stack.Count == 0)
    {
        stack.Push(A[i]);

        result.Add(-1);
    }
    else
    {
        result.Add(stack.Peek());

        stack.Push(A[i]);
    }
}

return 1;


