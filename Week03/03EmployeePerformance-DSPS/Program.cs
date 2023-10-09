using System;

namespace _03EmployeePerformance_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* an employee  will receive a score from 0 - 100 and get a message depending on his or her
             * performance. 90-100 --> employee of the month / 
             * 0 - 50 --> Your lazy ass did nothing at all for the past 7 years of this company, YOU ARE FIRED!
             * 51 - 60 --> Please work better, you're the laughing stock of this company
             * 61 - 70 --> You work well, but sometimes you're a bunch of zombies
             * 71 - 89 --> you're average, nothing special, please don't complain!*/
            
            string answer = Console.ReadLine();
            int score;
            bool succes = Int32.TryParse(answer, out score);

            //int score = Convert.ToInt32(Console.ReadLine());
            if (succes)
            {
                if (score >= 0 && score <= 50) //(score > -1 && score < 51)
                {
                    Console.WriteLine("Your lazy ass did nothing at all for the past 7 years of this company, YOU ARE FIRED!");
                }
                else if (score > 50 && score <= 60)
                {
                    Console.WriteLine("Please work better, you're the laughing stock of this company");
                }
                else if (score > 60 && score <= 70)
                {
                    Console.WriteLine("You work well, but sometimes you're a bunch of zombies");
                }
                else if (score > 70 && score <= 89)
                {
                    Console.WriteLine("You're average, nothing special, please don't complain");
                }
                else if (score >= 90 && score <= 100)
                {
                    Console.WriteLine("You're the employee of the month!");
                }
                else
                {
                    Console.WriteLine("Your score is invalid! Please enter it again!");
                }
            }
            else
            {
                Console.WriteLine("Please enter an actual score.");
            }

        }
    }
}