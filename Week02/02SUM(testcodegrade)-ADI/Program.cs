using System;

namespace _02SUM_testcodegrade__ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = 
                new System.Globalization.CultureInfo("en-US");

            double d1 = Convert.ToDouble(Console.ReadLine());
            double d2 = Convert.ToDouble(Console.ReadLine());
            double d3 = Convert.ToDouble(Console.ReadLine());
            
            //optie 1
            double sum = d1 + d2 + d3;
            Console.WriteLine((int)sum);

            /*//optie 2
            int sumInt = (int)sum;
            Console.WriteLine(sumInt);

            //optie 3
            int sum = (int)(d1 + d2 + d3);
            Console.WriteLine(sum);*/
        }
    }
}