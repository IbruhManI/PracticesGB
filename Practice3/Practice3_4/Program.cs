using System;

namespace Practice3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] sea_battle = 
            {
                { "X","X","X","X","o","o","o","X","o","o"},
                { "o","o","o","o","o","o","o","X","o","o"},
                { "X","o","X","o","o","o","o","X","o","o"},
                { "X","o","o","o","o","o","o","o","o","o"},
                { "X","o","o","X","o","o","o","o","o","o"},
                { "o","o","o","o","o","o","X","o","o","o"},
                { "o","o","o","o","X","o","X","o","o","o"},
                { "o","o","o","o","o","o","o","o","o","o"},
                { "o","o","o","o","X","X","o","o","o","o"},
                { "o","X","X","o","o","o","o","o","X","o"},
            };
            for(int i=0;i<sea_battle.GetLength(0);i++)
            {
                for(int j=0;j<sea_battle.GetLength(1);j++)
                {
                    Console.Write($"{sea_battle[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
