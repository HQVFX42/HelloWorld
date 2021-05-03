using System;
namespace GuessRandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            int result = 0;

            while (true)
            {
                int guess = int.Parse(Console.ReadLine());
                result++;
                Console.WriteLine("시도한 횟수: " + result);
                if ( guess > number)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                    Console.WriteLine();
                }
                else if(guess <number)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("정답입니다.");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
