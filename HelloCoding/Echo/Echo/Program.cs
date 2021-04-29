using System;

namespace Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input...");
            string userInput = Console.ReadLine();

            Console.Write(">> ");
            Console.Write(userInput);
            Console.Write(" <<");
            Console.WriteLine();
        }
    }
}
