
using System.Linq;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int[,] berries = new int [N,2];
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            berries[i,0] = Convert.ToInt32(input[0]);
            berries[i,1] = Convert.ToInt32(input[1]);
        }

        List<int> result = new List<int>();
        List<int> usedRows = new List<int>();


        while (result.Count < N)
        {
            int QuerryBerriesMax = MaxNumbers(berries, usedRows, 0);
            result.Add(QuerryBerriesMax);
            usedRows.Add(QuerryBerriesMax);

            int QuerryBerriesDiff = MinimalDifferences(berries, usedRows);
            result.Add(QuerryBerriesDiff);
            usedRows.Add(QuerryBerriesDiff);
        }
        if (result.Count > N) {
        result.RemoveAt(result.Count - 1);
        }

        int High = HighMax(berries,result);
                Console.WriteLine($"{High}");
        foreach (var index in result)
        {
            Console.Write($"{index + 1}" + " ");
        }

    }

    static int MaxNumbers(int[,] numbers, List<int> usedRows, int column)
    {
        int IndexMax = int.MinValue;
        int maxNumber = int.MinValue;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {

            if (!usedRows.Contains(i) && numbers[i, column] > maxNumber )
            {
                maxNumber = numbers[i, column];
                IndexMax = i; 
            } else if (!usedRows.Contains(i) &&numbers[i, column] == maxNumber){
                if (numbers[IndexMax, 0] - numbers[IndexMax, 1] < numbers[i, 0] - numbers[i, 1]){
                    IndexMax = i;} else { continue; }
            }
        }
        return IndexMax;

    }

    static int MinimalDifferences(int[,] numbers, List<int> usedRows)
    {
        int minDiffIndex = int.MinValue;
        int MinimalDifference = int.MaxValue;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            if (!usedRows.Contains(i))
            {
                int diff = Math.Abs(numbers[i, 0] - numbers[i, 1]);
                if (diff < MinimalDifference)
                {
                    MinimalDifference = diff;
                    minDiffIndex = i;
                }
            }
        }

        return minDiffIndex;
    }
    static int HighMax(int[,] berries, List<int> result){
    int currentHigh = 0; 
    int maxHigh = 0; 
     foreach (var c in result){
             currentHigh += berries[c,0];
             if (currentHigh >= maxHigh)
                 maxHigh = currentHigh;
              currentHigh -= berries[c,1];
         }  
     return maxHigh;
     }
}