using System;

namespace Punctuation_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string antwoord = Console.ReadLine();

            for (int i = 0; i < antwoord.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(antwoord[i]);
                }
                else if (antwoord[i] == antwoord[i-1] && ".,!?()[]{}:;'\"".Contains(antwoord[i]))
                {
                }
                else
                {
                    Console.Write(antwoord[i]);
                }
            }
        }
    }
}