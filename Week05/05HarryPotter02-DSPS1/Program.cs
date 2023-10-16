﻿using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05HarryPotter02_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            foreach (string item in File.ReadLines("Harry Potter and the Sorcerer.txt"))
            {
                counter++;
            }
            
            Console.WriteLine(counter.ToString());







            Console.Write("Number of lines: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            StreamWriter sr = File.CreateText($"harry-{lines}.txt");
            //create new file with specified lines


            foreach (string line in File.ReadLines(@"Harry Potter and the Sorcerer.txt"))
            {
                if (count <= lines)
                {
                    sr.WriteLine(count + " " + line); //only want the lines --> remove count
                    count++;
                }
                else break;
            }
            sr.Close();



            //option 2: doing the same as code above
            count = 0;
            StreamReader read = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            StreamWriter write = File.CreateText($"harry-{lines}-option2.txt");
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