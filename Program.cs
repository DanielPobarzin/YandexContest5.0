using System;

class Program
{
    static void Main()
    {
        string[] firstMatch = Console.ReadLine().Split(':');
        int firstMatch1 = Convert.ToInt32(firstMatch[0]);
        int firstMatch2 = Convert.ToInt32(firstMatch[1]);

        string[] currentMatch = Console.ReadLine().Split(':');
        int currentMatch1 = Convert.ToInt32(currentMatch[0]);
        int currentMatch2 = Convert.ToInt32(currentMatch[1]);

        int MatchLocation = Convert.ToInt32(Console.ReadLine());
        int CountGoals1 = firstMatch1 + currentMatch1;
        int CountGoals2 = firstMatch2 + currentMatch2;

        if (CountGoals1 > CountGoals2)
        {
            Console.WriteLine(0);
            return;
        }

        if (CountGoals1 == CountGoals2 && MatchLocation == 2)
        {
            if (firstMatch1 <= currentMatch2)
            {
                Console.WriteLine(1);
                return;
            }
            else
            {
                Console.WriteLine(0);
                return;
            }

        }
        else if (CountGoals1 == CountGoals2 && MatchLocation == 1)
        {
            if (currentMatch1 <= firstMatch2)
            {
                Console.WriteLine(1);
                return;
            }
            else
            {
                Console.WriteLine(0);
                return;
            }
        }

        int goalsNeed = 0;
        if (MatchLocation == 1)
        {
            goalsNeed = CountGoals2 - CountGoals1;
            if (goalsNeed + currentMatch1 <= firstMatch2)
            {
                goalsNeed += 1;
            }
        }
        else
        {
            goalsNeed = CountGoals2 - CountGoals1 + 1;
            if (firstMatch1 > currentMatch2)
            {
                goalsNeed -= 1;
            }

        }
        Console.WriteLine(goalsNeed);
    }
}