using System;

namespace _05Revision_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("+ ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }



            string PIN = Console.ReadLine();

            while(PIN != "1111")
            {
                Console.WriteLine("Enter your PIN again: ");
                PIN = Console.ReadLine();
            }

            Console.WriteLine("Phone unlocked");







        }
    }
}