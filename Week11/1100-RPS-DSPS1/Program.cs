using System;

namespace _1100_RPS_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPS game = new RPS();
            string answer;
            Console.WriteLine("Rock (0), Paper (1), Scissors (2) - (S) to stop");

            while((answer = Console.ReadLine()) != "S")
            {
                game.Me = (Hand)Convert.ToInt32(answer);
                string result = game.Turn();
                Console.WriteLine(result);
            }

            Console.WriteLine($"Final score: {game.ToString()}");

        }
    }
}