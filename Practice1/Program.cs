using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToShortDateString();
            string name = "Erlan";
            Console.WriteLine($"Hello, {name}, today is {time}");
        }
    }
}
