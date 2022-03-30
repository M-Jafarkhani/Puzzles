class Solution 
{
    int[] data = new int[10000000];

    int headIndex = -1;

    int min = Integer.MAX_VALUE;

    public void push(int x) 
    {
        data[++headIndex] = x;

        if (headIndex == 0 || x < min)
        {
            min = x;
        }
    }

    public void pop() 
    {
        if (headIndex == -1)
        {
            return;
        }

        int result = data[headIndex--];

        if (result == min)
        {
            setMin();
        }
    }

    public int top() 
    {
        if (headIndex == -1)
        {
            return -1;
        }

        return data[headIndex];
    }

    public int getMin() 
    {
        if (headIndex == -1)
        {
            return -1;
        }

        return min;
    }

    private void setMin()
    {
        min = Integer.MAX_VALUE;

        if (headIndex == -1)
        {
            min = -1;

            return;
        }

        for (int i = 0; i <= headIndex; i++)
        {
            if (min > data[i])
            {
                min = data[i];
            }
        }
    }
}
