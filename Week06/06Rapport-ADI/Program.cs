using System;

namespace _06Rapport_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel studenten zijn er? ");
            int student = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hoeveel testen heb je gedaan? ");
            int testen = Convert.ToInt32(Console.ReadLine());

            int[,] rapport = new int[student, testen];

            for (int i = 0; i < rapport.GetLength(0); i++) // i < student
            {
                for (int j = 0; j < rapport.GetLength(1); j++) // j < testen
                {
                    Console.Write($"Resultaat van test {j+1} van student {i + 1}: ");
                    rapport[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            //gemiddelde berekenen per student
            for (int i = 0; i < student; i++) //of rapport.GetLength(0)
            {
                int som = 0;
                for (int j = 0; j < testen; j++) //of rapport.GetLength(1)
                {
                    som += rapport[i, j];
                }
                Console.WriteLine($"Gemiddelde van student {i + 1} is {som / testen}");
            }
            /* [0,0]
             * [0,1]
             * [0,2]
             * [0,3]
             * [1,0]
             * [1,1]*/

            //gemiddelde per test
            for (int i = 0; i < testen; i++)
            {
                int som = 0;
                for (int j = 0; j < student; j++)
                {
                    som += rapport[j, i];
                }
                Console.WriteLine($"Gemiddelde van test {i + 1} is {som / student}");
            }
            /* [0,0]
             * [1,0]
             * [2,0]
             * [3,0]
             * [0,1]
             * [1,1]*/

        }
    }
}