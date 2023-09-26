using System;

namespace _02AverageOf3_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());

            int average = (int)((number1 + number2 + number3) / 3);
            Console.WriteLine(average);

        }
    }
}