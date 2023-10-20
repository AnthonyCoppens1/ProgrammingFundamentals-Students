using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05HarryPotterCharacter03_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read through file line by line
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Gryffindor"))
                {
                    int first = item.IndexOf(';'); //finds the first instance of ;
                    string substring = item.Substring(first + 1);
                    int second = substring.IndexOf(";"); //finds the secon instance of ;

                    Console.WriteLine(substring.Substring(0, second));
                }
            }


            //regex for a birth year
            Regex rx = new Regex(@"[0-9]{4}");
            MatchCollection matches = rx.Matches(File.ReadAllText("Characters.csv"));
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value + " ");
            }


        }
    }
}