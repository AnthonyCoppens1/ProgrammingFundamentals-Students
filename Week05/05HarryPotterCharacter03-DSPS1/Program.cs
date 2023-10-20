using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05HarryPotterCharacter03_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read through the file line by line
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Gryffindor"))
                {
                    int first = item.IndexOf(';'); //find the index of first ; to determine where first field ends and second field starts
                    //extract a substring of the line starting from char after first ; --> just 'first' would mean you look at ;
                    string substring = item.Substring(first + 1);
                    int second = substring.IndexOf(';'); // find index of the second ; INSIDE OF SUBSTRING
                    Console.WriteLine(substring.Substring(0, second)); 
                    //print substring that starts from the beginning of substring and ends just before second ;
                }
            }
            


            Regex rx = new Regex(@"[0-9]{4}");
            //checks for any 4 digits in a row between range of 0 and 0 (including those)

            MatchCollection match = rx.Matches(File.ReadAllText("Characters.csv"));
            foreach (Match item  in match)
            {
                Console.WriteLine(item.Value + " ");
            }

        }
    }
}