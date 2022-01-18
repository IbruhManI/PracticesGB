using System;

namespace Practice3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phone Directory: ");
            string[,] phn_dir =
            {
                {"Chkalov Erlan", "+996 xx xx xx"},
                {"Daniil Monin", "+7 xxx xxx xx xx xx"},
                {"Dmitriy Fedotov","+7 xxx xxx xx xx xx"},
                {"Maria Mazur", "+7 xxx xxx xx xx xx"},
                {"Peter Parker", "+1 234 567-89-00"}
            };
            for (int i = 0; i < phn_dir.GetLength(0); i++)
            {
                for (int j = 0; j < phn_dir.GetLength(1); j++)
                {
                    Console.Write($"{phn_dir[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
