using System;
using System.IO;

namespace _05HarryPotter02_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of lines: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            StreamWriter sr = File.CreateText($"Harry-{lines}.txt");
            //maakt nieuwe file aan met aantal lijnen

            foreach (string line in File.ReadLines(@"Harry Potter and the Sorcerer.txt"))
            {
                if (count <= lines)
                {
                    sr.WriteLine(count + " " + line);
                    count++;
                }
                else break;
            }
            sr.Close();


            //optie 2: zelfde uitvoeren als hierboven
            count = 0;
            StreamReader read = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            StreamWriter write = File.CreateText($"Harry-{lines}VERSIE2.txt");

            while (count <= lines)
            {
                write.WriteLine(count + " " + read.ReadLine());
                count++;
            }
            read.Close();
            write.Close();
        }
    }
}