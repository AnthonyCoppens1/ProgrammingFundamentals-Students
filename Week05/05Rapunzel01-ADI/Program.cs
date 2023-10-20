using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05Rapunzel01_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file lezen
            //versie 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textCheck = sr.ReadToEnd();
            sr.Close();*/

            //file openen en lezen, sluiten --> allemaal in 1 lijn
            //VERSIE 2
            string text = File.ReadAllText("Rapunzel.txt");

            //characters tellen
            Console.WriteLine($"# chars: {text.Length}");

            //lijnen tellen
            Console.WriteLine($"# lijnen: {File.ReadAllLines("Rapunzel.txt").Length}");

            //lijnen tellen op een andere manier
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lijnen = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lijnen++;
            }
            sr.Close();
            Console.WriteLine("# lijnen: " + lijnen);


            //tellen van de letters A of a
            //versie WHILE

            int countA = 0;
            sr = File.OpenText("Rapunzel.txt");
            while(!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (c == 'a' || c == 'A')
                {
                    countA++;
                }
                //if ("Aa".Contains(c)){ countA++; }
            }
            sr.Close();
            Console.WriteLine($"# A's of a's: {countA}");


            //tellen van dezelfde letter
            //VERSIE FOREACH
            countA = 0;
            foreach(char item in text.ToLower()) //ref naar string text = File.ReadAllText("Rapunzel.txt");
            {
                if (item == 'a')
                {
                    countA++;
                }
            }
            Console.WriteLine($"# A's of a's: {countA}");

            //tel A's en a's
            //versie FOR
            countA = 0;
            for (int i = 0; i <text.Length; i++)
            {
                if (text[i] == 65 || text[i] == 97)
                {
                    countA++;
                }
            }
            Console.WriteLine($"# A's of a's: {countA}");



            //woorden tellen
            //versie foreach
            int countWord = 0;
            foreach (char item in text)
            {
                if (item == ' ')
                {
                    countWord++;
                }
            }
            Console.WriteLine($"# woorden: {countWord}");


            //woord Rapunzel tellen
            string woord = "";
            int countRapunzel = 0;
            foreach (char c in text.ToLower())
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn".Contains(c))
                {
                    woord += c; // woord = woord + c
                }
                else
                {
                    if (woord == "rapunzel")
                    {
                        countRapunzel++;
                    }
                    woord = "";
                }
            }
            Console.WriteLine($"# Rapunzels: {countRapunzel}");



            //WERKEN MET REGEX
            Regex rx = new Regex("rapunzel", RegexOptions.IgnoreCase);
            //Regex rx = new Regex("Rapunzel|rapunzel|RAPUNZEL");
            MatchCollection matches = rx.Matches(text); //string text = File.ReadAllText("Rapunzel.txt")
            Console.WriteLine($"# Rapunzels: {matches.Count}");


            //woorden controleren met REGEX --> \w 
            rx = new Regex(@"\w+", RegexOptions.IgnoreCase);
            matches = rx.Matches(text);
            Console.WriteLine($"# woorden: {matches.Count}");

            rx = new Regex("rapunzel", RegexOptions.IgnoreCase);
            Console.WriteLine(rx.Replace(text, "Anthony"));

        }
    }
}