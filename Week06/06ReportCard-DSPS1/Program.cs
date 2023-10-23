using System;

namespace _06ReportCard_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNumber of tests: ");
            int tests = Convert.ToInt32(Console.ReadLine());

            double[,] reportCard = new double[students, tests];

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < tests; j++)
                {
                    Console.Write($"Grade of test {j + 1} of student {i + 1}: ");
                    reportCard[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            //average of a student
            for (int i = 0; i < students; i++) //reportCard.GetLength(0)
            {
                double sum = 0;
                for (int j = 0; j < tests; j++)
                {
                    sum += reportCard[i, j];
                }
                Console.WriteLine($"average for student {i + 1} is {sum / tests}");
            }
            //reportcard [0,0], [0,1], [0,2], [1,0], [1,1]...


            //average for every test
            for (int i = 0; i < tests; i++)
            {
                double sum = 0;
                for (int j = 0; j < students; j++)
                {
                    sum += reportCard[j, i];
                }
                Console.WriteLine($"Average for test {i + 1} is {sum / students}");
            }
            //reportcard [0,0], [1,0], [2,0], [0,1], [1,1]...


        }
    }
}