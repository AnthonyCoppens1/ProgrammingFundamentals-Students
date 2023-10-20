using System;
using System.IO;

namespace _05Files_Reading_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tekst file openen en uitlezen, ofwel eerst doc lezen dan printen of omgekeerd
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text);


            //nog is printen
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                //string line = input.ReadLine();
                //Console.WriteLine(line);
                Console.WriteLine("-->" + input.ReadLine());
            }


            //character per character uitlezen en een spatie toevoegen
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write((char)input.Read() + " ");
            }
            input.Close();


            //foreach om door tekst te lezen
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("-->" + item);
            }

            //character per character
            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write(c);
            }
        }
    }
}