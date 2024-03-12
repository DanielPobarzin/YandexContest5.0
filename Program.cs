using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] lengths = Console.ReadLine().Split();
        int[] ropes = new int[N];
        int AllRops = 0;
        int minRopeLength = 0;
        for (int i = 0; i < N; i++)
        {
            ropes[i] = int.Parse(lengths[i]);
        }
        Array.Sort(ropes);
        for (int i = 0; i < N - 1; i++)
        {
            AllRops += ropes[i];
        }

        if (AllRops < ropes[N-1]){
            minRopeLength = ropes[N-1] - AllRops;
        } else if (AllRops == ropes[N-1]) {
            minRopeLength = AllRops * 2;
        } else if (AllRops > ropes[N-1]){
             minRopeLength = AllRops + ropes[N-1];
        }

        Console.WriteLine(minRopeLength);
    }
}
