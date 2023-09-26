using System;

namespace _02Sum_testcase__DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = 
                new System.Globalization.CultureInfo("en-US");

            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());

            int sum = (int)(n1 + n2 + n3);
            Console.WriteLine(sum);

            //option 2
            //double sum = n1 + n2 + n3;
            //Console.WriteLine((int)sum);

            //option 3
            //Console.WriteLine(sum.ToString("0.00"));
        }
    }
}