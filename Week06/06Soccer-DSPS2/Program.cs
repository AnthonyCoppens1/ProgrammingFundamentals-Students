using System;

namespace _06Soccer_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] team = new string[3][];
            for (int i = 0; i < team.Length; i++)
            {
                //add every row
                Console.WriteLine($"Enter names (split by space) for row {i + 1}");
                team[i] = Console.ReadLine().Split(); //splits space out and players into array
            }

            /* row 1: John Bob Alice
             * row 2: Eve Carol
             * row 3: David */

            //get formation by length of every row
            Console.WriteLine($"Formation {team[0].Length}-{team[1].Length}-{team[2].Length}");

            //print out every player
            foreach (var item in team) //loop every row
            {
                foreach (var player in item) //loops every element in the row
                {
                    Console.Write(player + " ");
                }
                Console.WriteLine();
            }


        }
    }
}