using System;

namespace LotteryNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lotLength = 6;
            int[] lotNums = new int[lotLength];

            Random random = new Random();

            int lotNumIndex = 0;
            while (lotNumIndex < lotLength)
            {
                lotNums[lotNumIndex] = random.Next(1, 46);

                bool hasDuplicate = false;
                for (int i = 0; i < lotNumIndex; i++)
                {
                    if (lotNums[lotNumIndex] == lotNums[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (!hasDuplicate)
                {
                    lotNumIndex++;
                }
            }

            Console.Write("Lottery Number: ");
            for (int i = 0; i < lotLength; i++)
            {
                Console.Write(lotNums[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
