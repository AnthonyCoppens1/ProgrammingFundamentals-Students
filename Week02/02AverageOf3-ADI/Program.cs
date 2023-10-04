using System;

namespace _02AverageOf3_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = 
                new System.Globalization.CultureInfo("en-US");

            double getal1 = Convert.ToDouble(Console.ReadLine());
            double getal2 = Convert.ToDouble(Console.ReadLine());
            double getal3 = Convert.ToDouble(Console.ReadLine());

            double gemiddelde = (getal1 + getal2 + getal3) / 3;
            Console.WriteLine((int)gemiddelde);

        }
    }
}