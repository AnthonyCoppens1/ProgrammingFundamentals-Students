using System;

namespace _11OO_BSS_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BSS spel = new BSS();
            string antwoord;
            Console.WriteLine("Blad (0), steen (1), schaar (2) - om te stoppen (S)");

            while((antwoord = Console.ReadLine()) != "S")
            {
                spel.Mezelf = (Hand)Convert.ToInt32(antwoord);
                string uitslag = spel.Beurt();
                Console.WriteLine(uitslag);
            }
            Console.WriteLine($"Eindstand: {spel.ToString()}");
        }
    }
}