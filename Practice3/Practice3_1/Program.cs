using System;

namespace Practice3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] arr = new int[4, 4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = rnd.Next(100);
                        Console.Write($"{arr[i, j]}\t");
                    }
                    else
                        Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
