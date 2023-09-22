using System;

namespace _01Uppercas_TestCase_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name? ");
            string naam = Console.ReadLine();

            naam = naam.ToUpper();

            Console.WriteLine("HELLO " + naam);





            /*Console.WriteLine($"HELLO {naam.ToUpper()}");

            Console.WriteLine("HELLO {0}", naam.ToUpper());
            
             string zin = ("Hello " + naam).ToUpper();*/

        }
    }
}