using System;


namespace Week3Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float[,] students = new float[2, 5];
            for (int i = 0; i < 5; i++)
            {
                students[0, i] = Convert.ToSingle(Console.ReadLine());   
            }
            for (int i = 0; i < 5; i++)
            {
                students[1, i] = Convert.ToSingle(Console.ReadLine());
            }
            double gradeAvg1 = 0;
            double gradeAvg2 = 0;
            float gradeSum1 = 0;
            float gradeSum2 = 0;

            for (int i = 0; i <= 5; i++)
            {
                gradeSum1 += students[0, 1];
            }
            for (int i = 0; i <= 5; i++)
            {
                gradeSum2 += students[1, 1];
            }
            Console.WriteLine(gradeSum2);
            Console.WriteLine(gradeSum1);

            gradeAvg1 = gradeSum1 / 5.00;
            gradeAvg2 = gradeSum2 / 5.00;
            Console.WriteLine("Average for group 1 is {0:F2}", gradeAvg1);
            Console.WriteLine("Average for group 2 is {0:F2}", gradeAvg2);
        }
    }
}
