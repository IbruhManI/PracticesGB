using System;

namespace Practice2_5
{
    class Program
    {
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Console.Write("Enter max temp for a day: ");
            float maxt = float.Parse(Console.ReadLine());
            Console.Write("Enter min temp for a day: ");
            float mint = float.Parse(Console.ReadLine());
            float avg = (maxt + mint) / 2;
            Console.WriteLine($"Average temp for a day is {avg}");
            Console.Write("Enter the number of month: ");
            int month = int.Parse(Console.ReadLine());
            Months typed_month = (Months)month;
            if (month <= 12 && month > 0)
            {
                if (avg > 0 && month <= 2)
                    Console.WriteLine("Rainy winter");
                else if (avg > 0 && month == 12)
                    Console.WriteLine("Rainy winter");
                else
                    Console.WriteLine($"You have entered {typed_month.ToString()}");
                return;
            }
            Console.WriteLine("There is no such a month");
        }
    }
}
