using System;

namespace _02Sum_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());

            //option 1
            double sum = n1 + n2 + n3;
            Console.WriteLine((int)sum);

            //option 2
            /*int sum = (int)(n1 + n2 + n3);
            Console.WriteLine(sum);*/

            //Console.WriteLine(Math.Floor(sum)); --> rounds down ALWAYS
            //Console.WriteLine(Math.Round(sum)); --> rounds according to mathematical rounding rules



        }
    }
}