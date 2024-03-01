using System;

class Program
{
    static void Main()
    {
         string[] TreeVasya =Console.ReadLine().Split();
        string[] TreeMasha = Console.ReadLine().Split();

        int bucketVasya = Convert.ToInt32(TreeVasya[0]);
        int lengthVasya = Convert.ToInt32(TreeVasya[1]) * 2;
        int startVasya = bucketVasya - lengthVasya / 2;
        int endVasya = bucketVasya + lengthVasya / 2;

        int bucketMasha = Convert.ToInt32(TreeMasha[0]);
        int lengthMasha = Convert.ToInt32(TreeMasha[1]) * 2; 
        int startMasha = bucketMasha - lengthMasha / 2;
        int endMasha = bucketMasha + lengthMasha / 2;

        int start = Math.Min(startVasya, startMasha);
        int end = Math.Max(endVasya, endMasha);

        if (endVasya < startMasha || endMasha < startVasya) 
        {
            Console.WriteLine(lengthVasya + lengthMasha + 2); 
        }
        else
        {
            Console.WriteLine(end - start + 1);
        }
    }
}


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         string[] TreeVasya =Console.ReadLine().Split();
//         string[] TreeMasha = Console.ReadLine().Split();
//         int P = Convert.ToInt32(TreeVasya[0]);
//         int V = Convert.ToInt32(TreeVasya[1]);
//         int Q = Convert.ToInt32(TreeMasha[0]);
//         int M = Convert.ToInt32(TreeMasha[1]);
//         int min = Math.Min(P - V, Q - M);
//         int max = Math.Max(P + V, Q + M);

//         Dictionary <int,string> Trees = new Dictionary<int, string>();  
//         for (int i = min; i <= max; i++){
//             Trees.Add(i,"No");
//         }
//         for (int i = P - V; i <= P + V; i++){
//             if (Trees[i] == "No"){
//                 Trees[i] = "Yes";
//             } else{
//             continue;
//             }
//         }
//         for (int i = Q - M; i <= Q + M; i++){
//             if (Trees[i] == "No"){
//                 Trees[i] = "Yes";
//             } else{
//             continue;
//             }
//         }
//         int CountTrees = 0;
//         foreach (var Tree in Trees){
//             if (Tree.Value == "Yes"){
//                  CountTrees++;
//             } else {
//                 continue;
//             }
//         } 
//         Console.WriteLine(CountTrees);
//     } 
// }