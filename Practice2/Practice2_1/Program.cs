using System;

namespace Practice2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter max temp for a day: ");
            float maxt = float.Parse(Console.ReadLine());
            Console.Write("Enter min temp for a day: ");
            float mint = float.Parse(Console.ReadLine());
            Console.WriteLine($"Average temp for a day is {(maxt + mint) / 2}");
        }
    }
}


