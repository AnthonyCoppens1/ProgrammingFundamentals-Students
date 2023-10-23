namespace _06ReportCard_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of tests: ");
            int tests = Convert.ToInt32(Console.ReadLine());

            double[,] reportCard = new double[students, tests];

            for (int i = 0; i < students; i++) //i < reportCard.GetLength(0)
            {
                for (int j = 0; j < tests; j++) //i < reportCard.GetLength(1)
                {
                    Console.Write($"Grade for test {j + 1} of student {i + 1}: ");
                    reportCard[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            //average for every student
            for (int i = 0; i < students; i++)
            {
                double sum = 0;
                for (int j = 0; j < tests; j++)
                {
                    sum += reportCard[i, j];
                }
                Console.WriteLine($"average for student {i + 1} is {sum / tests}");
            }


            //average for every test
            for (int i = 0; i < tests; i++)
            {
                double sum = 0;
                for (int j = 0; j < students; j++)
                {
                    sum += reportCard[j, i];
                }
                Console.WriteLine($"average for test {i + 1} is {sum / students}");
            }

            Console.WriteLine();

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < tests; j++)
                {
                    Console.Write(reportCard[i, j] + " ");
                }
                Console.WriteLine();
            }





        }
    }
}