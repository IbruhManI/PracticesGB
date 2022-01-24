using System;

namespace Practice4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers separated by a space to sum:");
            string s = Console.ReadLine();
            float summ = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                    summ += int.Parse(s[i].ToString());
            }
            Console.WriteLine(summ);
        }
    }
}
