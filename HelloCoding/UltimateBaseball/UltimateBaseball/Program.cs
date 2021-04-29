using System;

namespace UltimateBaseball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+---------------------------------------------------------+");
            Console.WriteLine("|                   Ultimate Baseball Game                |");
            Console.WriteLine("+---------------------------------------------------------+");
            Console.WriteLine("|   컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다.   |");
            Console.WriteLine("|   각 숫자는 0~9에 하나며 중복되는 숫자는 없습니다.      |");
            Console.WriteLine("|   모든 숫자와 위치를 맞히면 승리합니다.                 |");
            Console.WriteLine("|   숫자와 순서가 둘 다 맞으면 스트라이크입니다.          |");
            Console.WriteLine("|   숫자만 맞고 순서가 틀리면 볼입니다.                   |");
            Console.WriteLine("|   숫자가 틀리면 아웃입니다.                             |");
            Console.WriteLine("+---------------------------------------------------------+");

            Console.WriteLine(">> 수비수가 고른 숫자");
            int num1 = 3;
            int num2 = 1;
            int num3 = 9;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(">> 수비수가 다시 고른 숫자");
            num1 = 8;
            num2 = 2;
            num3 = 0;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
