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

            int strikeCount = 0;
            int ballCount = 0;

            Random random = new Random();

            int[] numbers = new int[3];
            int index = 0;
            while(index <3)
            {
                numbers[index] = random.Next(0, 10);

                bool hasDuplicate = false;
                for (int i = 0; i < index; i++)
                {
                    if(numbers[index] == numbers[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }
                if(!hasDuplicate)
                {
                    index++;
                }
            }

            //Console.WriteLine(">> 수비수 숫자");
            //for (int i=0; i<3; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            while (strikeCount != 3)
            {
                strikeCount = 0;
                ballCount = 0; 

                Console.WriteLine(">> 공격수는 숫자를 골라주세요");

                int[] guesses = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("> Enter" + (i+1) + "number");
                    guesses[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(">> 공격수가 고른 숫자");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(guesses[i] +" ");
                }
                Console.WriteLine();
               
                if (guesses[0] == guesses[2] || guesses[0] == guesses[1] || guesses[1] == guesses[2])
                {
                    Console.WriteLine("같은 숫자를 입력하면 안 됩니다.");
                    continue;
                }
                else
                {
                    //if (guesses[0] == numbers[0])
                    //{
                    //    strikeCount = strikeCount + 1;
                    //}
                    //else if (guesses[0] == numbers[1] || guesses[0] == numbers[2])
                    //{
                    //    ballCount = ballCount + 1;
                    //}

                    //if (guesses[1] == numbers[1])
                    //{
                    //    strikeCount = strikeCount + 1;
                    //}
                    //else if (guesses[1] == numbers[0] || guesses[1] == numbers[2])
                    //{
                    //    ballCount = ballCount + 1;
                    //}

                    //if (guesses[2] == numbers[2])
                    //{
                    //    strikeCount = strikeCount + 1;
                    //}
                    //else if (guesses[2] == numbers[0] || guesses[2] == numbers[1])
                    //{
                    //    ballCount = ballCount + 1;
                    //}
                    for(int i=0; i<3; i++)
                    {
                        for(int j=0; j<3; j++)
                        {
                            if(guesses[i] == numbers[j])
                            {
                                if (i == j)
                                {
                                    strikeCount++;
                                }
                                else
                                {
                                    ballCount++;
                                }
                            }
                        }
                    }

                    Console.Write("Strike: ");
                    Console.WriteLine(strikeCount);
                    Console.Write("Ball: ");
                    Console.WriteLine(ballCount);
                    Console.Write("Out : ");
                    Console.WriteLine(3 - strikeCount - ballCount);

                    if(strikeCount == 3)
                    {
                        Console.WriteLine("정답입니다");
                        break;
                    }
                }
            }
        }
    }
}
