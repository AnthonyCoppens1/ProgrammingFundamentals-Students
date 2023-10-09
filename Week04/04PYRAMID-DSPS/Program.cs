using System;

namespace _04PYRAMID_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop number 1
            int x = 4;

            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //loop number 2
            for (int i = 0; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            //Loop number 3
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
            //Loop number 4
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