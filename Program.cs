using System;
using System.Collections.Generic;

class Program
{
     static void Main()
    {
        int CeilCount;
        int RookCount = 0;
        int BishopCount = 0;
        string[,] boardChess = new string[8, 8];
        List<(int, int)> BPositions = new List<(int, int)>();
        List<(int, int)> RPositions = new List<(int, int)>();
        for (int i = 0; i < 8; i++)
        {
            string line = Console.ReadLine();
            char[] item = line.ToCharArray();
            for (int j = 0; j < 8; j++)
            {
                boardChess[i, j] = item[j].ToString();
                switch(boardChess[i, j]){
                case "B": BPositions.Add((i, j));
                          BishopCount++;
                          break;
                case "R":
                          RPositions.Add((i, j));
                          RookCount++;
                          break;
                }
            }
        }
        CeilCount = 64 - (Bishop( BPositions, boardChess) + BishopCount) - (Rook(RPositions, boardChess) + RookCount);
        Console.WriteLine(CeilCount);
    }
        static int Bishop( List<(int, int)> BPositions, string[,] boardChess){
            int Count = 0;
        foreach (var position in BPositions){
            int row = position.Item1;
            int col = position.Item2;

            for (int i = row + 1, j = col + 1; i < 8 && j < 8; i++, j++)
            {
                if (boardChess[i, j] == "*")
                    {boardChess[i, j] = "x";
                    Count++;
                } else if (boardChess[i, j] == "x") {
                        continue;
                }else {
                        break;
                }
            }
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (boardChess[i, j] == "*")
                    {boardChess[i, j] = "x";
                    Count++;
                }else if (boardChess[i, j] == "x") {
                        continue;
                }else {
                        break;
                }
            }

            for (int i = row - 1, j = col + 1; i >= 0 && j < 8; i--, j++)
            {
                if (boardChess[i, j] == "*")
                {boardChess[i, j] = "x";
                Count++;
                }else if (boardChess[i, j] == "x") {
                        continue;
                }else {
                        break;
                }
            }

            for (int i = row + 1, j = col - 1; i < 8 && j >= 0; i++, j--)
            {
                if (boardChess[i, j] == "*")
                {boardChess[i, j] = "x";
                Count++;
                }else if (boardChess[i, j] == "x") {
                    continue;
                }else {
                    break;
                }
            }
         }
         return Count;
        }
         static int Rook( List<(int, int)> RPositions, string[,] boardChess){
          int Count = 0;
          foreach (var position in RPositions)
        {
            
            int row = position.Item1;
            int col = position.Item2;

            for (int j = col - 1; j >= 0; j--)
            {
                if (boardChess[row, j] == "*")
                {boardChess[row, j] = "x";
                    Count++;
                }
                else if (boardChess[row, j] == "x") {
                    continue;
                }else {
                    break;
                }
            }

            for (int j = col + 1; j < 8; j++)
            {
                if (boardChess[row, j] == "*")
                { boardChess[row, j] = "x";
                    Count++;
                }
                else if (boardChess[row, j] == "x") {
                    continue;
                }else {
                    break;
                }
            }

            for (int i = row - 1; i >= 0; i--)
            {
                if (boardChess[i, col] == "*")
                {boardChess[i, col] = "x";
                    Count++;
                }
               else if (boardChess[i, col] == "x") {
                    continue;
                }else {
                    break;
                }
            }

            for (int i = row + 1; i < 8; i++)
            {
                if (boardChess[i, col] == "*")
                {boardChess[i, col] = "x";
                    Count++;
                }
                      else if (boardChess[i, col] == "x") {
                    continue;
                }else {
                    break;
                }
            }
       }
       return Count;
       }
}

