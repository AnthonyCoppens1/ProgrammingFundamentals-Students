using System;

namespace _06Voetbal_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] team = new string[3][];
            
            for (int i = 0; i < team.Length; i++)
            {
                //iedere rij toevoegen
                Console.WriteLine($"Geef de namen (splits met spatie) van rij {i + 1}: ");
                team[i] = Console.ReadLine().Split(' ');
            }

            /* 3-4-3
             * rij 1: eden messi courtois 
             * rij 2: lukaku jean Anthony Bert
             * rij 3: kevin tom jef */

            Console.WriteLine($"Formatie: {team[0].Length}-{team[1].Length}-{team[2].Length}");

            foreach (var item in team) //loop door iedere rij/array
            {
                foreach (var player in item) //loop door ieder element van iedere array
                {
                    Console.Write(player + " ");
                }
                Console.WriteLine();
            }
        }
    }
}