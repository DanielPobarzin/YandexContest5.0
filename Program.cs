using System;

class Program
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int[,] cells = new int [N,2];
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            cells[i,0] = Convert.ToInt32(input[0]);
            cells[i,1] = Convert.ToInt32(input[1]);
        }

        int perimeter = Perimeter(cells);
        Console.WriteLine(perimeter);
    }

    static int Perimeter(int[,] cells)
    {
        int perimeter = 4 * cells.GetLength(0);
        int[] directRow = { 0, 1, 0, -1 };
        int[] directColumn = { 1, 0, -1, 0 };

        for (int i = 0; i < cells.GetLength(0); i++){
            for (int j = 0; j < 4; j++){
                int newRow = cells[i,0] + directRow[j];
                int newCol = cells[i,1] + directColumn[j];
                for (int k = 0; k < cells.GetLength(0); k++){
                    if (cells[k,0] == newRow && cells[k,1] == newCol){
                    perimeter--;
                    break;
                    }

            }
        }
    }
    return perimeter;
}
}