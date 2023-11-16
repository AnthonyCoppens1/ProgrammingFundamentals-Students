using System;

namespace WordNest_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string nest = Console.ReadLine();
            int counter = 0;

            while (nest != word)
            {
                nest = nest.Remove(nest.IndexOf(word), word.Length);
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}