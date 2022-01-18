using System;

namespace Practice2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Petrov";
            int receipt = 3287;
            int total = 52210;
            Console.WriteLine(" _____________________________________");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|           OOO ChekNaZakaz           |");
            Console.WriteLine($"|              Чек № {receipt}             |");
            Console.WriteLine($"|            Кассир: {name}           |");
            Console.WriteLine("| 1. Брус 18х18 7,2 куб.м. х 2700     |");
            Console.WriteLine("| 2. Доска обрезная сосна 11,3 куб. м.|");
            Console.WriteLine("|    х 2900                           |");
            Console.WriteLine("|=====================================|");
            Console.WriteLine($"|Всего...........................{total}|");
            Console.WriteLine("|ККМ 11111111 ИНН 222222222222  № 3287|");
            Console.WriteLine("|12.06.08 11:43                 Петров|");
            Console.WriteLine("|ПРОДАЖА                         №3287|");
            Console.WriteLine("|1                           =52210.00|");
            Console.WriteLine("|ИТОГ     =52210.00                   |");
            Console.WriteLine($"| НАЛИЧНЫМИ                     ={total}|");
            Console.WriteLine("||||||||||||||||||ФП|||||||||||||||||||");
            Console.WriteLine("|                     ЭКЛЗ 3333333333 |");
            Console.WriteLine("|                     00061528 #025843|");
            Console.WriteLine("|_____________________________________|");
        }
    }
}
