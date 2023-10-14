using System;

namespace _04Pyramide_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("#2");
            for (int i = 0; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("#3");
            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            Console.WriteLine("#4");
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}