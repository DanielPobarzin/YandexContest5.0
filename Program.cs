using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double CountPress = 0;
        for (int i = 0; i < n; i++)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double remainder = a % 4;
            decimal fraction = (decimal)a % 4 / 4M; 
            switch (fraction)
            {
            case 0M:
                    CountPress += a / 4;
                break;
            case 0.25M:
                    CountPress += Math.Truncate( a/4 )+ 1;
                break;
            case 0.50M:
                    CountPress += Math.Truncate( a/4 ) + 2;
                break;
            case 0.75M:
                    CountPress += Math.Ceiling( a/4 )+ 1;
                break;
            }
        }   
        Console.WriteLine(CountPress); 
        }
    }
