using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Anthony!");

            //programma voor het opslaan van naam onder string
            Console.WriteLine("What's your name? ");
            string naam = Console.ReadLine();

            //print variabele
            Console.WriteLine(naam);
            //optie 1
            /*Console.WriteLine("Hello " + naam + "!");


            //optie 2
            Console.WriteLine($"Hello {naam}!");*/


            //optie 3
            //0 wordt vervangen door de variabele na de komma. Oneindige mogelijkheden.
            Console.WriteLine("Hello {0}!", naam);

            //uitbreiding van bovenstaande regel
            string tafel = "Jan";
            string deur = "Louis";

            Console.WriteLine("Hello {0} {1} {2}", naam, tafel, deur);


            //alles hierachter is commentaar, maar wel enkel op deze regel
            /* alles wat we hiertussen typen is gezien als commentaar
             * zelfs als ik op enter duw
             * is dit niet van belang.
             * Deze tekst wordt niet gelezen
             * door het programma of de computer. */




        }
    }
}