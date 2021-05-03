using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 숫자를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];
            double[] weights = new double[studentCount];

            int studentNum = 0;
            while(studentNum < studentCount)
            {
                Console.WriteLine("몇 번째 학생의 정보를 추가할까요?");
                studentNum = int.Parse(Console.ReadLine()) - 1;

                if (studentNum >= 0 && studentNum <= studentCount - 1)
                {
                    Console.WriteLine("나이를 입력하세요.");
                    ages[studentNum] = int.Parse(Console.ReadLine());

                    Console.WriteLine("이름을 입력하세요.");
                    names[studentNum] = Console.ReadLine();

                    Console.WriteLine("키를 입력하세요.");
                    heights[studentNum] = int.Parse(Console.ReadLine());

                    Console.WriteLine("무게를 입력하세요.");
                    weights[studentNum] = int.Parse(Console.ReadLine());
                    studentNum += 1;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            studentNum = 0;
            Console.WriteLine("---------------------------------------");
            while (studentNum < studentCount)
            {
                Console.Write(studentNum + 1); Console.WriteLine("번째 학생");
                Console.Write("이름: "); Console.WriteLine(names[studentNum]);
                Console.Write("나이: "); Console.WriteLine(ages[studentNum]);
                Console.Write("키: "); Console.WriteLine(heights[studentNum]);
                Console.Write("무게: "); Console.WriteLine(weights[studentNum]);
                studentNum += 1;
            }

        }
    }
}
