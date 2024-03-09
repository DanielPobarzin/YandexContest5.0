using System;

class Program
{
    static void Main()
    {
        int K = Convert.ToInt32(Console.ReadLine());
        int[] x = new int[K];
        int[] y = new int[K];
        for (int i = 0; i < K; i++)
        {
            string[] coordinates = Console.ReadLine().Split(' ');
            x[i] = Convert.ToInt32(coordinates[0]);
            y[i] = Convert.ToInt32(coordinates[1]);
        }

        int minX = x[0], maxX = x[0];
        int minY = y[0], maxY =  y[0];
        for (int i = 0; i < K; i++)
        {
            if (x[i] < minX)
                minX = x[i];
            if (x[i] > maxX)
                maxX = x[i];
            if (y[i] < minY)
                minY = y[i];
            if (y[i] > maxY)
                maxY = y[i];
        }

        Console.WriteLine(minX + " " + minY +" "+ maxX + " " + maxY);
    }
}