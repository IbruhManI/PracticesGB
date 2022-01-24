using System;

namespace Practice4_3
{
    class Program
    {
        enum Seasons
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }
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
        static string monthPick(int month)
        {
            Months typedMon = (Months)month;
            string seas = "";
            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    seas = Seasons.Winter.ToString();
                    break;
                case 3:
                case 4:
                case 5:
                    seas = Seasons.Spring.ToString();
                    break;
                case 6:
                case 7:
                case 8:
                    seas = Seasons.Summer.ToString();
                    break;
                case 9:
                case 10:
                case 11:
                    seas = Seasons.Autumn.ToString();
                    break;             
            }
            Console.WriteLine(seas);
            return $"You have entered {typedMon.ToString()}";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of month: ");
            int numMon = int.Parse(Console.ReadLine());
            if(numMon<=12&&numMon>0)
            {
                string mon = monthPick(numMon);
                Console.WriteLine(mon);
                return;
            }
            Console.WriteLine("There is no such a month, bruh");
        }
    }
}
