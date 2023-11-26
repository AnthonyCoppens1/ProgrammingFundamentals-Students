using System;
using System.Collections.Generic;

namespace _08StudentDatabase_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DOEN = Console.ReadLine();
            List<string> naam = new List<string>();
            List<int> leeftijd = new List<int>();
            List<DateTime> geboortedatum = new List<DateTime>();

            int index = 1;

            while (DOEN != "END")
            {
                if (DOEN == "ADD")
                {
                    Console.Write("Naam: "); naam.Add(Console.ReadLine());
                    Console.Write("Leeftijd: "); leeftijd.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Geboortedatum: "); geboortedatum.Add(Convert.ToDateTime(Console.ReadLine()));
                    Console.Write($"De nummer van de student is: {index}\n\n");
                    index++;

                    DOEN = Console.ReadLine();
                }
                else if (DOEN == "ADJUST")
                {
                    Console.Write("Wat is de nummer van de student? ");
                    int nummer = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Naam: "); naam[nummer - 1] = Console.ReadLine();
                    Console.Write("Leeftijd: "); leeftijd[nummer - 1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Geboortedatum: "); geboortedatum[nummer - 1] = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine();
                    DOEN = Console.ReadLine();
                }
                else if (DOEN == "DELETE")
                {
                    Console.Write("Wat is de nummer van de student? ");
                    int nummer = Convert.ToInt32(Console.ReadLine());
                    naam.RemoveAt(nummer - 1);
                    leeftijd.RemoveAt(nummer - 1);
                    geboortedatum.RemoveAt(nummer - 1);
                    Console.Write($"De informatie van student {nummer} is uit de database gehaald\n\n");
                    DOEN = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Je hebt een verkeerd keyword ingegeven. WE SLUITEN DE DATABASE.");
                    break;
                }
            }

            Console.WriteLine("Sessie is voorbij! Dit zijn onze studenten: \n");

            for (int i = 0; i < naam.Count; i++)
            {
                Console.Write(naam[i] + "\t" + leeftijd[i] + "\t" + DateOnly.FromDateTime(geboortedatum[i]) + "\n");
            }

        }
    }
}