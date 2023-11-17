using System;
using System.Linq;

namespace MixAndMatch_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            
            if (s1.Length > s2.Length)
            {
                for (int i = 0; i < s2.Length; i++) //tot lengte van kleinste getal
                {
                    Console.Write(Convert.ToString(s1.ElementAt(i)) + Convert.ToString(s2.ElementAt(i)));
                }
                for (int j = s2.Length; j < s1.Length; j++)
                {
                    Console.Write(Convert.ToString(s1.ElementAt(j)));
                }
            }
            else
            {
                for (int i = 0; i < s1.Length; i++) //tot lengte van kleinste getal
                {
                    Console.Write(Convert.ToString(s2.ElementAt(i)) + Convert.ToString(s1.ElementAt(i)));
                }
                for (int j = s1.Length; j < s2.Length; j++)
                {
                    Console.Write(Convert.ToString(s2.ElementAt(j)));
                }
            }
        }
    }
}