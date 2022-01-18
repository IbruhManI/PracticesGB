using System;

namespace Practice3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some word: ");
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write($"{word[i]}");
            }
            Console.WriteLine();
        }
    }
}
