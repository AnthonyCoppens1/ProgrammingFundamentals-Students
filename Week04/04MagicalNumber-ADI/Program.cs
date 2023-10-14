using System;

namespace _04MagicalNumber_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double som;

            while (n >= 10)
            {
                if (n > 99)
                {
                    som = Math.Pow(n / 100, 2) + Math.Pow((n % 100) / 10, 2) + Math.Pow(n % 10, 2);
                    Console.WriteLine($"{n / 100}^2 + {(n % 100) / 10}^2 + {n % 10}^2 = {som}");
                }
                else
                {
                    som = Math.Pow(n / 10, 2) + Math.Pow(n % 10, 2);
                    Console.WriteLine($"{n / 10}^2 + {n % 10}^2 = {som}");
                }
                n = (int)som;
            }
        }
    }
}