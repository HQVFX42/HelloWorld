using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int passcodeLength = 6;
            int[] passCodeNums = new int[passcodeLength];
            int passcodeChance = 5;
            int[] userInput = new int[passcodeLength];

            Console.WriteLine("Password: ");
            for (int i = 0; i < passcodeLength; i++)
            {
                passCodeNums[i] = random.Next(0, 10);
                Console.Write(passCodeNums[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int index = 0; index < passcodeChance; index++)
            {
                for (int i = 0; i < passcodeLength; i++)
                {
                    Console.WriteLine(i+1 + "번째 숫자를 입력하세요");
                    userInput[i] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCorrect = true;
                for(int i = 0; i < passcodeLength; i++)
                {
                    if (userInput[i] != passCodeNums[i])
                    {
                        isPasswordCorrect = false;
                        Console.WriteLine("Incorrect");
                        Console.WriteLine("You have" + (passcodeChance - index - 1));
                        break;
                    }
                }
                
                if(isPasswordCorrect)
                {
                    Console.WriteLine("open");
                    break;
                }
            }
            
        }
    }
}
