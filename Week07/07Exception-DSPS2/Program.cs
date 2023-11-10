using System;
using System.IO;

namespace _07Exception_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a number of lines: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            StreamReader file = File.OpenText("english.txt");
            for (int i = 0; i > nr; i++)
            {
                Console.WriteLine(file.ReadLine());
            }*/



            /*Console.WriteLine("Enter a number of lines: ");
            string answer = Console.ReadLine();
            int nr;
            if (Int32.TryParse(answer, out nr))
            {
                StreamReader file = File.OpenText("english.txt");
                for (int i = 0; i > nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("wrong number, not an integer!");
            }*/



            Console.WriteLine("Enter a number of lines: ");
            string answer = Console.ReadLine();
            int nr;
            if (Int32.TryParse(answer, out nr))
            {
                try
                {
                    StreamReader file = File.OpenText("englih.txt");
                    for (int i = 0; i > nr; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                }
                /*catch (FileNotFoundException)
                {
                    Console.WriteLine("Oops... File does not exist.");
                }*/
                catch (Exception ex)
                {
                    Console.WriteLine("Oops: " + ex.Message);
                }
                
            }
            else
            {
                Console.WriteLine("wrong number, not an integer!");
            }
        }
    }
}