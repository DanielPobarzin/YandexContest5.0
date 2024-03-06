using System;
using System.Collections.Generic;
using System.Data;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] Line = Console.ReadLine().Split(' ');
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++){

            numbers[i] = (Convert.ToInt64(Line[i]) % 2 == 0)? 0:1;
        }

        List<string> Symbols = GenCombSymbols(numbers.Length - 1);

         foreach (string combination in Symbols) 
        {
           string expression = GenExpression(combination, numbers);
            DataTable equation = new DataTable();
           int result = Convert.ToInt32(equation.Compute(expression, ""));
                if (result % 2 != 0)
                {
                    Console.WriteLine(combination);
                     break;
                }
        }
    }   
    static List<string> GenCombSymbols(int n)
    {
        List<string> Symbols = new List<string>();
        GenerateComb(n, "", Symbols);
        return Symbols;
    }

    static void GenerateComb(int n, string nowSymbols, List<string> Symbols)
    {
        if (n == 0)
        {
            Symbols.Add(nowSymbols);
            return;
        }

        GenerateComb(n - 1, nowSymbols + "x", Symbols);
        GenerateComb(n - 1, nowSymbols + "+", Symbols);
    }

     static string GenExpression(string combination , int[] numbers)
    {
         string expression = numbers[0].ToString();
            for (int i = 0; i < combination.Length; i++)
            {
                if (combination[i] == 'x')
                {
                    expression += " * ";
                }
                else if (combination[i] == '+')
                {
                    expression += " + ";
                }
                expression = expression + numbers[i + 1].ToString();
            }
            return expression;
    }
       
} 