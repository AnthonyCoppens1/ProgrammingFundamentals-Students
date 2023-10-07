using System;

namespace _03WerknemerScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //schrijf een programma dat de score van een werknemer
            //opvraagt en deze indeelt in een categorie:
            //(efficient 70-89) / werknemerVanDeMaand(90-100) / tamzak (0-19)
            //gemiddeld (45-69) / teleurstelling (20-44)


            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 0 && score < 20)
            {
                Console.WriteLine("Je bent een tamzak!");
            }
            else if (score >= 20 && score < 45) {
                Console.WriteLine("Je bent een teleurstelling");
            }
            else if (score >= 45 && score < 70)
            {
                Console.WriteLine("Je bent een gemiddelde werknemen");
            }
            else if (score >= 70 && score < 90)
            {
                Console.WriteLine("Je bent efficiënt");
            }
            else
            {
                Console.WriteLine("Je bent de werknemer van de maand.");
            }
        }
    }
}