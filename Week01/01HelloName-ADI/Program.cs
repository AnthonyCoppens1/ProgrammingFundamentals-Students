using System;

namespace _01HelloName_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name? ");
            string voornaam = Console.ReadLine();

            Console.WriteLine("What's your last name? ");
            string achternaam = Console.ReadLine();

            //optie 1
            //Console.WriteLine("Hello " + voornaam + " " + achternaam);

            //optie 2
            Console.WriteLine($"Hello {voornaam} {achternaam}");

            //optie 3
            //Console.WriteLine("Hello {0} {1}", voornaam, achternaam);



        }
    }
}