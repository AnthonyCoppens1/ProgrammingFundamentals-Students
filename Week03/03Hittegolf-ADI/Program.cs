using System;
using System.Diagnostics.Metrics;

namespace _03Hittegolf_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Schrijf een programma dat de temperatuur voor 5 opeenvolgende
             * dagen vraagt aan de gebruiker en telkens opslaat onder een nieuwe
             * variabele per dag. Bereken dan of schrijf een programma dat bepaald 
             * of we spreken van een hittegolf of niet.
             * Hittegolf: 5 dagen >= 25 WAARVAN 3 dagen >= 30
             * OUTPUT: het is een hittegolf OF het is geen hittegolf*/

            System.Threading.Thread.CurrentThread.CurrentCulture = 
                new System.Globalization.CultureInfo("en-US");

            double dag1 = Convert.ToDouble(Console.ReadLine());
            double dag2 = Convert.ToDouble(Console.ReadLine());
            double dag3 = Convert.ToDouble(Console.ReadLine());
            double dag4 = Convert.ToDouble(Console.ReadLine());
            double dag5 = Convert.ToDouble(Console.ReadLine());

            int counter = 0;
            switch (dag1)
            {
                case >= 30:
                    counter++;
                    break;
            }
            switch (dag2)
            {
                case >= 30:
                    counter++;
                    break;
            }
            switch (dag3)
            {
                case >= 30:
                    counter++;
                    break;
            }
            switch (dag4)
            {
                case >= 30:
                    counter++;
                    break;
            }
            switch (dag5)
            {
                case >= 30:
                    counter++;
                    break;
            }

            if (dag1 >= 25 && dag2 >= 25 && dag3 >= 25 && dag4 >= 25 
                && dag5 >= 25 && counter >= 3)
            {
                Console.WriteLine("Het is een hittegolf!");
            }
            else
            {
                Console.WriteLine("Het is GEEN hittegolf");
            }

        }
    }
}