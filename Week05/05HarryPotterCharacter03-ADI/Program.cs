using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05HarryPotterCharacter03_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Gryffindor"))
                {
                    int first = item.IndexOf(';'); //eerste keer dat we ; tegenkomen
                    //substring hier bouwen
                    string substring = item.Substring(first + 1);
                    int second = substring.IndexOf(';');
                    Console.WriteLine(substring.Substring(0, second));
                    //substring aanpassen, start bij h (aangegeven bij 1e substring melding)
                    //loopt van 1e char (0) tot second --> 1e keer tegenkomen van ; in substring
                }
            }

            Regex rx = new Regex(@"[0-9]{4}");
            //checkt op 4 opeenvolgende getallen tussen 0 en 9 (inclusief die 2)
            MatchCollection matches = rx.Matches(File.ReadAllText("Characters.csv"));
            foreach(Match item in matches)
            {
                Console.WriteLine(item.Value + " ");
            }
        }
    }
}