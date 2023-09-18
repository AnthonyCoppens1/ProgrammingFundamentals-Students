using System;

namespace HelloWorld_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //coding program for reading name with a variable
            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();

            //First name pull from input
            Console.WriteLine("Hello " + firstName + "!");
            Console.WriteLine($"Hello {firstName}!");
            Console.WriteLine("Hello {0}!", firstName);

            //first and last name from input
            Console.WriteLine("Hello " + firstName + " " + lastName + "!");
            Console.WriteLine($"Hello {firstName} {lastName}!");
            Console.WriteLine("Hello {0} {1}!", firstName, lastName);

            string name, age;
            name = "Jean-Baptiste";
            age = "13";


            //This is one line of comments

            /* Now I can Write multiple lines of comments
             * and I can continue on the next line
             * after pressing enter */

            /* This is one line */


            /*If you use Console.Write it doesn't add a new line after the text output.
            Which means that if you want to read input after the output of a Console.Write
            It'll be right behind the previous output that you have to write your input.*/

            string door = "wood";
            string table = "metal";

            Console.Write(door);
            Console.Write(" " + table);

        }
    }
}