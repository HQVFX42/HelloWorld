using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("========================");
                Console.WriteLine(" 가위=1, 바위=2, 보=3 ");
                Console.WriteLine("========================");

                Random random = new Random();
                int comNumber = random.Next(1, 4);

                Console.WriteLine("1, 2, 3 중 하나를 선택");
                int userNumber = int.Parse(Console.ReadLine());

                if(userNumber >=1 && userNumber <=3)
                {
                    Console.Write("컴퓨터가 낸 수: ");
                    Console.WriteLine(comNumber);

                    int result = userNumber - comNumber;

                    if (result == -1 || result == 2)
                    {
                        Console.WriteLine("Lose");
                        break;
                    }
                    else if (result == -2 || result == 1)
                    {
                        Console.WriteLine("Win");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Draw");
                    }
                }
                else
                {
                    Console.WriteLine("올바른 값이 아닙니다");
                }
                
            }
        }
    }
}
