using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        long n = Convert.ToInt64(inputs[0]);
        int k = Convert.ToInt32(inputs[1]);
        int d = Convert.ToInt32(inputs[2]);
        long x = n;
        int c = 0;
        int counZero = -1;
                     bool addedZero = false; 
        while (c < d)
        {

            for (int j = 0; j < 10; j++)
            {
                if ((x * 10 + j) % k == 0 && addedZero == false)
                {
                    addedZero = j == 0;
                        x = x * 10 + j;
                    break;
                }
            } 
            if (addedZero)
                counZero++;
            c++;
        }
        if (x % k == 0){
        Console.Write(x);
            if (addedZero){
            string zeros = new string('0', counZero);
            Console.Write(zeros);
        }   
        }else{
            Console.Write(-1);
        }
        
    }
}