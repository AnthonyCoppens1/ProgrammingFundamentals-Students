using System;
using System.Diagnostics.Metrics;

namespace _03HeatWaveSimulator_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a programme that asks for the temperature of 5 days in a row.
             * Check whether or not this temperature is higher than 25 ° C
             * also check if 3 of the 5 days are higher than 30°C
             * If this is the case, output: BELGIUM IS ON FIRE
             * If not output: It's probably raining again.
             * temp has to be a double! */

            double day1 = Convert.ToDouble(Console.ReadLine());
            double day2 = Convert.ToDouble(Console.ReadLine());
            double day3 = Convert.ToDouble(Console.ReadLine());
            double day4 = Convert.ToDouble(Console.ReadLine());
            double day5 = Convert.ToDouble(Console.ReadLine());

            int counter = 0;

            if (day1 >= 30)
            {
                counter++;
            }
            if (day2 >= 30)
            {
                counter++;
            }
            if (day3 >= 30)
            {
                counter++;
            }
            if (day4 >= 30)
            {
                counter++;
            }
            if (day5 >= 30)
            {
                counter++;
            }

            if (day1 >= 25 && day2 >= 25 && day3 >= 25 && day4 >= 25 && day5 >= 25 && counter >= 3)
            {
                Console.WriteLine("Belgium is on fire!");
            }
            else
            {
                Console.WriteLine("It's probably raining again.");
            }


        }
    }
}