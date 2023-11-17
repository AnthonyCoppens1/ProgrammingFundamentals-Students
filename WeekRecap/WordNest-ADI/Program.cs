using System;

namespace WordNest_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string woord = Console.ReadLine();
            string nest = Console.ReadLine();

            int counter = 0;

            while (nest != woord)
            {
                nest = nest.Remove(nest.IndexOf(woord), woord.Length);
                Console.WriteLine(nest);
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}