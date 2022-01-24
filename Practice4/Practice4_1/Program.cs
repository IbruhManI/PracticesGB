using System;

namespace Practice4_1
{
    class Program
    {
        static string Fio(string firstName, string lastName, string patronymic)
        {
            return $"You have entered {firstName} {lastName} {patronymic}";
        }
        static void Main(string[] args)
        {
            string fio1 = Fio("Chkalov", "Erlan", "Almazbekovich");
            string fio2 = Fio("Monin", "Daniil", "");
            string fio3 = Fio("Aliev", "Ali", "Avchievich");
            Console.WriteLine(fio1);
            Console.WriteLine(fio2);
            Console.WriteLine(fio3);
        }
    }
}
