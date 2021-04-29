using System;

namespace _99dan
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=9; i++)
            {
                Console.WriteLine(i +"단");
                for(int j=1; j<=9; j++)
                {
                    Console.Write("[" + i + "*" + j + " = " + i * j + "] ");
                }
                Console.WriteLine();
            }
        }
    }
}
