using System;

namespace _04MagicalNumber_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //2 digit number
            double sum;
            while (n >= 10)
            {
                if (n > 99)
                {
                    sum = Math.Pow(n/100, 2) + Math.Pow((n % 100)/10, 2) + Math.Pow(n % 10, 2);
                    Console.WriteLine($"{n / 100}^2 + {(n % 100)/10}^2 + {n %10}^2 = {sum}");
                }
                else
                {
                    sum = Math.Pow(n / 10, 2) + Math.Pow(n % 10, 2);
                    Console.WriteLine($"{n / 10}^2 + {n % 10}^2 = {sum}");
                }
                
                n = (int)sum;
            }


        }
    }
}