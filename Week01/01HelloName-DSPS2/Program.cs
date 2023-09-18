using System;

namespace _01HelloName_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                      
            //Call for a name and save under variable firstName
            Console.WriteLine("What's your first name? ");
            string firstName = Console.ReadLine();

            //last name saved under variable
            Console.WriteLine("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName);
            //Console.WriteLine($"Hello {firstName} {lastName}");
            //Console.WriteLine("Hello {0} {1}", firstName, lastName);


        }
    }
}