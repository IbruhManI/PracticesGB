using System;

namespace Practice2_2
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
            Console.Write("Enter the number of month: ");
            int month = int.Parse(Console.ReadLine());
            Months typed_month = (Months)month;
            if (month <= 12 && month > 0)
            {
                Console.WriteLine($"You have entered {typed_month.ToString()}");
                return;
            }
            Console.WriteLine("There is no such a month");
        }
    }
}
