using System;

namespace _01HelloName_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 01 Hello Name (test codegrade)

               Read the name and surname of a person and say 'Hello' to them.

Input/Output
input:
Anthony
Coppens
output:
Hello Anthony Coppens

input:
Elke
Boonen
output:
Hello Elke Boonen*/

            Console.WriteLine("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {lastName}");

        }
    }
}