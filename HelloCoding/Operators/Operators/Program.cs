using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinCount = 10;
            int a = 0;
            int b = 0;
            Console.WriteLine(coinCount);
            a = coinCount / 2 - 1;
            coinCount = coinCount - a;
            Console.WriteLine("a = " + a);
            Console.WriteLine(coinCount);
            b = coinCount / 2 + 2;
            coinCount = coinCount - b;
            Console.WriteLine("b = " + b);
            Console.WriteLine(coinCount);
        }
    }
}
