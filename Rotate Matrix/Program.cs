public class Solution 
{
	public void rotate(ArrayList<ArrayList<Integer>> a) 
    {
        int N = a.size();

        for (int i = 0; i < N / 2; i++)
        {
            for (int j = 0; j < N / 2 + N % 2; j++)
            {
                Integer x1 = a.get(i).get(j);
                Integer x2 = a.get(j).get(N - i - 1);
                Integer x3 = a.get(N - i - 1).get(N - j - 1);
                Integer x4 = a.get(N - j - 1).get(i);

                a.get(i).set(j,x4);
                a.get(j).set(N - i - 1,x1);
                a.get(N - i - 1).set(N - j - 1,x2);
                a.get(N - j - 1).set(i,x3);
            }
        }
     }
}
