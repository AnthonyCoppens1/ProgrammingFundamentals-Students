using System;

namespace Punctuation_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(input[i]);
                }
                else if (input[i] == input[i - 1] && ".,!?:;{}()[]'\"".Contains(input[i])) 
                { 
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}