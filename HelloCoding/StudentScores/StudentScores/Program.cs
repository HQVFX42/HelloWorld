using System;

namespace StudentScores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("반 수?");
            int classCount = int.Parse(Console.ReadLine());
            Console.WriteLine("학생 수?");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("과목 수?");
            int courseCount = int.Parse(Console.ReadLine());

            double[] courseScores = new double[courseCount];
            double[] totalScores = new double[studentCount];
            double[] classScores = new double[classCount];

            for (int classIndex =0; classIndex < classCount; classIndex++)
            {
                for (int studentIndex = 0; studentIndex < studentCount; studentIndex++)
                {
                    for (int courseIndex = 0; courseIndex < courseCount; courseIndex++)
                    {
                        Console.WriteLine(">> " + (classIndex + 1) + "반 <<");
                        Console.WriteLine((studentIndex + 1) + "번 학생 -" + (courseIndex + 1) + "- 과목 점수?");
                        courseScores[courseIndex] = double.Parse(Console.ReadLine());
                        totalScores[studentIndex] += courseScores[courseIndex];
                        Console.WriteLine();
                        courseScores[courseIndex] = 0;
                    }
                    classScores[classIndex] += totalScores[studentIndex];
                    Console.WriteLine((studentIndex + 1) + "번 학생 " + "총점: " + totalScores[studentIndex]);
                    Console.WriteLine((studentIndex + 1) + "번 학생 " + "평균: " + totalScores[studentIndex] / courseCount);
                    Console.WriteLine();
                    totalScores[studentIndex] = 0;
                }
                Console.WriteLine((classIndex + 1) + "반 평균: " + classScores[classIndex] / studentCount);
                Console.WriteLine("-------------------");
            }
            //for (int classIndex = 0; classIndex < classCount; classIndex++)
            //{
            //    for (int i = 0; i < studentCount; i++)
            //    {
            //            Console.WriteLine((classIndex + 1) + "반 " + (i + 1) + "번 학생");
            //            Console.WriteLine("총점: " + totalScores[i]);
            //            Console.WriteLine("평균: " + totalScores[i] / courseCount);
            //            Console.WriteLine("반 평균: " + classScores[classIndex] / studentCount);
            //            Console.WriteLine();
            //    }
            //}
        }
    }
}
