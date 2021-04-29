using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinCount = 10;

            Console.WriteLine("Add");
            coinCount += int.Parse(Console.ReadLine());
            Console.WriteLine("Current.." + coinCount);

            Console.WriteLine("Sub1");
            coinCount -= int.Parse(Console.ReadLine());
            Console.WriteLine("Current.." + coinCount);

            Console.WriteLine("Sub2");
            coinCount -= int.Parse(Console.ReadLine());
            Console.WriteLine("Current.." + coinCount);
        }
    }
}
