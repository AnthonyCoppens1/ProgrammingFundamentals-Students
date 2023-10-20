using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05Rapunzel01_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opening a file and read all of it
            //version 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textCheck = sr.ReadToEnd();
            sr.Close();*/

            //version 2
            string text = File.ReadAllText("Rapunzel.txt");

            //count some characters
            Console.WriteLine($"# chars: {text.Length}");

            //count lines
            Console.WriteLine($"# lines: {File.ReadAllLines("Rapunzel.txt").Length}");



            //count lines in a different way --> by reading them with a while
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;
            while(!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();
            Console.WriteLine($"# lines: " + lines);


            //count letters like A's and a's
            //version while
            int countA = 0;
            sr = File.OpenText("Rapunzel.txt");

            while (!sr.EndOfStream) 
            {
                char c = (char)sr.Read();
                if (c == 'a'|| c == 'A')
                {
                    countA++;
                }

                /*if ("Aa".Contains(c))
                {
                    countA++;
                }*/

            }
            sr.Close();
            Console.WriteLine($"# A's and a's: {countA}");



            //count A's and a's in string
            //version foreach
            countA = 0;
            foreach (char item in text.ToLower())
            {
                if (item == 'a')
                {
                    countA++;
                }
            }
            Console.WriteLine($"# A's and a's: {countA}");



            //counting A's and a's with a 
            //FOR-LOOP
            countA = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 65 || text[i] == 97)
                {
                    countA++;
                }
            }
            Console.WriteLine($"# A's and a's: {countA}");



            //count words
            //using foreach
            int countWords = 0;
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    countWords++;
                }
            }
            Console.WriteLine($"# words: {countWords}");



            //count word Rapunzel

            string word = "";
            int countRapunzel = 0;
            foreach (char c in text.ToLower())
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn".Contains(c))
                {
                    word += c;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        countRapunzel++;
                    }
                    word = "";
                }
            }
            Console.WriteLine($"# rapunzels: {countRapunzel}");



            //work with REGEX
            Regex rx = new Regex("rapunzel", RegexOptions.IgnoreCase);

            //another poss:  Regex rx = new Regex("rapunzel|Rapunzel|RAPUNZEL");
            MatchCollection matches = rx.Matches(text); //ref to string text = File.ReadAllText("Rapunzel.txt");
            Console.WriteLine($"# rapunzels: {matches.Count}");


            //check words using regex
            //\w checks for seperate words and the + indicates that the \w must appear at least 1 or more times.
            rx = new Regex(@"\w+",RegexOptions.IgnoreCase);
            matches = rx.Matches(text);
            Console.WriteLine($"# words: {matches.Count}");


            //replacing words with new ones.
            rx = new Regex("rapunzel", RegexOptions.IgnoreCase);
            Console.WriteLine(rx.Replace(text, "Anthony"));


        }
    }
}