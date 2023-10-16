using System;
using System.IO;

namespace _05Files_Reading_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open text file and read through the whole doc, either print out text then close, or close then print
            //NO Console.ReadLine(), NO Console.Write or WriteLine() --> we don't see it

            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text);


            //start to print the document again
            //version WHILE
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                //string line = input.ReadLine();
                //Console.WriteLine(line);
                Console.WriteLine("-->" + input.ReadLine()); //prints out the docment and shows where a new line started
            }
            input.Close();

            //version FOREACH
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("--> " + item);
            }



            //read through the document char by char and add a blank space after each char
            //version WHILE
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write((char)input.Read() + " ");
            }
            input.Close();


            //loop through the chars using a foreach
            //version FOREACH
            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write(c + "*");
            }
            
            


        }
    }
}