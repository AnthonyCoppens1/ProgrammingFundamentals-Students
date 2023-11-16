using System;

namespace WordNest_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wordNest = Console.ReadLine();

            int counter = 0;

            while (wordNest != word)
            {
                wordNest = wordNest.Remove(wordNest.IndexOf(word), word.Length);
                
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}