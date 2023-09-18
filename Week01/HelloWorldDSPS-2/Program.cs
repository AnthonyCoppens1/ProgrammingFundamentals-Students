using System;

namespace HelloWorldDSPS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Program to save first name inside of a string variable
            Console.WriteLine("What is your first name? ");

            string name;
            name = "Jean";

            Console.WriteLine(name);

            //Reads user input
            Console.WriteLine("What is your actual first name? ");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName); // print the variable

            //greeting people in 3 different ways to write code.
            Console.WriteLine("Hello " + firstName + "!");

            Console.WriteLine($"Hello {firstName}!");

            Console.WriteLine("Hello {0}!", firstName);

            string lastName = "Vermeulen";
            Console.WriteLine("Hello {0} {1}", firstName, lastName);

            //This is a way of commenting 1 single line of code
            /* This is a way of commenting on multiple
             * lines of code. We can keep going and there
             * is no limit to the amount of
             * lines. */

            /* one line is possible this way */

        }
    }
}