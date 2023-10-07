using System;

namespace _03NaamMaandSwitch_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //roep de maand op in de vorm van een getal en sla dit
            //op onder een variabele, vervolgens met behulp van een
            //switch case, toon de je naam van de maand afhankelijk van het getal

            Console.WriteLine("Geef de nummer van een maand: ");
            int maand;
            bool check = Int32.TryParse(Console.ReadLine(), out maand);
            if (check)
            {
                switch (maand)
                {
                    case 1:
                        Console.WriteLine("januari");
                        break;
                    case 2:
                        Console.WriteLine("februari");
                        break;
                    case 3:
                        Console.WriteLine("maart");
                        break;
                    case 4:
                        Console.WriteLine("april");
                        break;
                    case 5:
                        Console.WriteLine("mei");
                        break;
                    case 6:
                        Console.WriteLine("juni");
                        break;
                    case 7:
                        Console.WriteLine("juli");
                        break;
                    case 8:
                        Console.WriteLine("augustus");
                        break;
                    case 9:
                        Console.WriteLine("september");
                        break;
                    case 10:
                        Console.WriteLine("oktober");
                        break;
                    /*default:
                        Console.WriteLine("November of december");
                        break;*/
                }
            }
            else
            {
                Console.WriteLine("Dit is geen maand!");
            }


        }
    }
}