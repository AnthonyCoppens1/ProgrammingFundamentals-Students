using System;

namespace _04While_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VOORWAARDELIJKE HERHALING
            Console.Write("START! druk op y om verder te gaan: ");
            string antwoord = Console.ReadLine();

            while (antwoord == "y")
            {
                Console.Write("Druk op y om verder te gaan: ");
                antwoord = Console.ReadLine();
            }

            Console.WriteLine("Sorry, het is gedaan!");


            //Random getal genereren!
            /*Random randomGetal = new Random();
            int getal = randomGetal.Next(1, 20);

            Console.Write("Doe eens een gokje: ");
            int GOK = Convert.ToInt32(Console.ReadLine());

            int counter = 1;

            while (GOK != getal && counter < 10)
            {
                Console.Write("Doe nog een gokje: ");
                GOK = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            Console.WriteLine($"Je hebt {counter} gegokt!");
            Console.WriteLine($"Het getal was {getal}");
            Console.WriteLine("HET SPEL IS GEDAAN!");

            */

            //sequence van 3 9 27 ...
            Console.WriteLine("\nsequence 3 9 27 ...");
            int i = 3;
            Console.WriteLine(Int16.MaxValue);
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= 3;
            }



            //BELANGRIJK --> VOLGORDE VAN UW CODE
            Console.Write("\nGeef een getal in: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nsequence 1");
            i = x;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= x;
            }

            //LET OP JE VOLGORDE --> hier eerst vermenigvuldigen, dan uitprinten en controleren
            Console.WriteLine("\nsequence 2");
            i = x;
            while (i < Int16.MaxValue)
            {
                i *= x;
                Console.Write(i + " ");
            }



            //DO-WHILE --> voert 1 keer minstens uit en erna zolang de voorwaarde als True terugkeert
            Console.WriteLine("\nsequence 3");
            i = Convert.ToInt32(Console.ReadLine());
            do
            {
                i *= 3;
                Console.Write(i + " ");
            } while (i < Int16.MaxValue);

        }
    }
}