using System;

namespace _07Exception_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Geef een getal in: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            StreamReader file = File.OpenText("english.txt");
            for (int i = 0; i > nr; i++)
            {
                Console.WriteLine(file.ReadLine());
            }*/


            //foutmeldingen ontwijken met if-statements
            /*Console.WriteLine("Geef een getal in: ");
            string antwoord = Console.ReadLine();
            int nr;
            if (Int32.TryParse(antwoord, out nr))
            {
                StreamReader file = File.OpenText("english.txt");
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Dit is geen geldig getal!");
            }*/


            Console.WriteLine("Geef een getal in: ");
            string antwoord = Console.ReadLine();
            int nr;
            if (Int32.TryParse(antwoord, out nr))
            {
                string fileCheck = Console.ReadLine();
                try
                {
                    StreamReader file = File.OpenText(fileCheck);
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                }
                /*catch
                {
                    Console.WriteLine("Oeps, file niet gevonden!");
                }*/
                catch (Exception ex)
                {
                    Console.WriteLine("Oeps: " + ex.Message);
                }

            }
            else
            {
                Console.WriteLine("Dit is geen geldig getal!");
            }




        }
    }
}