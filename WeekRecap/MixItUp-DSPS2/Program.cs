using System;
using System.Linq;

namespace MixItUp_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            string c = "";
            string d = "";

            if (firstString.Length > secondString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    c = Convert.ToString(firstString.ElementAt(i));
                    d = Convert.ToString(secondString.ElementAt(i));
                    Console.Write(c + d);
                }
                for (int j = secondString.Length; j < firstString.Length; j++)
                {
                    c = Convert.ToString(firstString.ElementAt(j));
                    Console.Write(c);
                }
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    c = Convert.ToString(secondString.ElementAt(i));
                    d = Convert.ToString(firstString.ElementAt(i));
                    Console.Write(c + d);
                }
                for (int j = firstString.Length; j < secondString.Length; j++)
                {
                    c = Convert.ToString(secondString.ElementAt(j));
                    Console.Write(c);
                }
            }
        }
    }
}