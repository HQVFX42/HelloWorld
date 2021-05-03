using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            string inputOperator = Console.ReadLine();

            if(inputOperator == "+")
            {
                Console.Write(num1);
                Console.Write(inputOperator);
                Console.Write(num2);
                Console.Write(" = ");
                Console.WriteLine(num1 + num2);
            }
            else if (inputOperator == "-")
            {
                Console.Write(num1);
                Console.Write(inputOperator);
                Console.Write(num2);
                Console.Write(" = ");
                Console.WriteLine(num1 - num2);
            }
            else if (inputOperator == "*")
            {
                Console.Write(num1);
                Console.Write(inputOperator);
                Console.Write(num2);
                Console.Write(" = ");
                Console.WriteLine(num1 * num2);
            }
            else if (inputOperator == "/")
            {
                Console.Write(num1);
                Console.Write(inputOperator);
                Console.Write(num2);
                Console.Write(" = ");
                Console.WriteLine(num1 / num2);
            }
            else if (inputOperator == "%")
            {
                Console.Write(num1);
                Console.Write(inputOperator);
                Console.Write(num2);
                Console.Write(" = ");
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("Error");
            }

            int a = int.Parse(Console.ReadLine());
            if( a > 20 && a % 3 ==0)
            {
                Console.WriteLine("True");
            }
        }
    }
}
