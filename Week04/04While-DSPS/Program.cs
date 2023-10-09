using System;

namespace _04While_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE --> write a programme that only continues if you press y
            Console.Write("START! press y to continue: ");
            string answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.Write("Press y to continue: ");
                answer = Console.ReadLine();
            }
            Console.WriteLine("Your little game has ended!");


            //theory on generating random numbers
            Random randomGame = new Random();
            int number = randomGame.Next(1, 20);

            Console.Write("Guess a number: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            int counter = 1;

            while (number != guess && counter < 10)
            {
                Console.Write("Guess a number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            Console.WriteLine($"The number was {number}");
            Console.WriteLine("The guessing game has come to an end :'(");


            //sequence of 3 9 81 656 .. --> Int16.MaxValue
            Console.WriteLine("\nsequence of 3 9 81 656...");
            int i = 3;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= i;
            }

            //importance of order in your code
            Console.Write("\nEnter a number x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nsequence 1");
            i = x;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= x;
            }

            //importance of order in your code
            Console.WriteLine("\nsequence 2");
            i = x;
            while (i < Int16.MaxValue)
            {
                i *= x;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Int16.MaxValue);


            //do while will always loop at least 1 time
            //order of statements is important
            Console.WriteLine("\nsequence3");
            i = x;
            do
            {
                i *= x;
                Console.Write(i + " ");
            }while (i < Int16.MaxValue);

            //do while will always loop at least 1 time
            //order of statements is important
            Console.WriteLine("\nsequence4");
            i = x;
            do
            {
                Console.Write(i + " ");
                i *= x;
            } while (i < Int16.MaxValue);


        }
    }
}