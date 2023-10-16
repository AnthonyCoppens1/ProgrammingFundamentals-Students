using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05Rapunzel01_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opening file and reading all the contents
            //version 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string text = sr.ReadToEnd();
            sr.Close();*/

            //version 2
            string text = File.ReadAllText("Rapunzel.txt");

            //count the amount of characters
            Console.WriteLine($"# characters: {text.Length}");

            //count the lines
            Console.WriteLine($"# lines: {File.ReadAllLines("Rapunzel.txt").Length}");

            //count lines in different way
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();
            Console.WriteLine($"# lines: {lines}");



            //Count the A's and a's
            //version WHILE
            int countA = 0;
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (c == 'A' | c == 'a')
                {
                    countA++;
                }

                /*if ("Aa".Contains(c))
                {
                    countA++;
                }*/
            }
            sr.Close();
            Console.WriteLine($"# A's or a's: {countA}");


            //count a's and A's
            //version foreach
            countA = 0;
            foreach (char item in text.ToLower()) 
            {
                if ("Aa".Contains(item))
                {
                    countA++;
                }
            }
            Console.WriteLine($"# A's or a's: {countA}");



            //count A's or a's
            //version FOR
            countA = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == 65 || text[i] == 97) //ElementAt(i)
                {
                    countA++;
                }
            }
            Console.WriteLine($"# A's or a's: {countA}");


            //count WORDS!
            //foreach --> careful on how to structure
            int countWord = 0;
            foreach (char item in text) //Reference to: LINE 2: string text = File.ReadAllText("Rapunzel.txt");
            {
                if (item == ' ')
                {
                    countWord++;
                }
            }
            Console.WriteLine($"# words: {countWord}");


            //count WORDS!
            //while
            countWord = 0;
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream) //read through text char by char
            {
                char c = (char)sr.Read(); //read through it
                if ("azertyuiopmlkjhgfdsqwxcvbn".Contains(Char.ToLower(c)))
                {
                    if (c != '\'') //we use the \ to escape the sequence and can then use the following character to check --> \' checks for ' --> \" --> "
                    {
                        countWord++;
                    }
                }
            }
            Console.WriteLine($"#words: {countWord}");



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


            //working with REGEX
            Regex regex = new Regex("rapunzel", RegexOptions.IgnoreCase);

            //another poss: Regex regex = new Regex("Rapunzel|rapunzel|RAPUNZEL");

            MatchCollection matches = regex.Matches(text); //string text = File.ReadAllText("Rapunzel.txt")
            Console.WriteLine($"# rapunzels: {matches.Count}");


            //\w checks for seperate words and the + indicates that the \w must appear at least 1 time or more
            regex = new Regex(@"\w+", RegexOptions.IgnoreCase);
            matches = regex.Matches(text);
            Console.WriteLine($"# words: {matches.Count}");



            //replace a word in a text
            regex = new Regex("rapunzel", RegexOptions.IgnoreCase);
            Console.WriteLine(regex.Replace(text,"Anthony"));



        }
    }
}