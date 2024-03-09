using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        int N = Convert.ToInt32(input[0]);
        int K = Convert.ToInt32(input[1]);

        int[] price = new int[N];
        input = Console.ReadLine().Split(" ");
        for (int i = 0; i < N; i++)
        {
            price[i] = Convert.ToInt32(input[i]);
        }

        int maxP = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j <= Math.Min(i + K, N - 1); j++)
            {
                int p = price[j] - price[i];
                if (p > maxP)
                {
                    maxP = p;
                }
            }
        }

        Console.WriteLine(maxP);
    }
}