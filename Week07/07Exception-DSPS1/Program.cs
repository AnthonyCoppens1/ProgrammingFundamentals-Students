using System;

namespace _07Exception_DSPS1
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
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }*/

            //USING EXCEPTION HANDLING
            Console.WriteLine("Enter a number of lines: ");
            string answer = Console.ReadLine();
            int nr;
            if (Int32.TryParse(answer, out nr))
            {
                try
                {
                    StreamReader file = File.OpenText("englih.txt");
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops: " + e.Message);
                }
                
            }
            else
            {
                Console.WriteLine("wrong number");
            }

        }
    }
}