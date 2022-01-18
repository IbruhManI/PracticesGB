using System;

namespace Practice2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("You have entered the even number");
            }
            else
            {
                Console.WriteLine("You have entered the odd number");
            }
        }
    }
}
