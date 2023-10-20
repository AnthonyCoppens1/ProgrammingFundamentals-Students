using System;
using System.IO;

namespace _05HarryPotter02_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of lines? ");
            int lines = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            StreamWriter sr = File.CreateText($"harry-{lines}.txt");
            //create a new file with specified lines

            foreach (string line in File.ReadLines(@"Harry Potter and the Sorcerer.txt"))
            {
                if (count <= lines)
                {
                    sr.WriteLine(count + " " + line); //only want line? remove count
                    count++;
                }
                else break;
            }
            sr.Close();


            //option 2: doing the exact same as the above code
            count = 0;
            StreamReader read = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            StreamWriter write = File.CreateText($"harry-{lines}.txt");

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