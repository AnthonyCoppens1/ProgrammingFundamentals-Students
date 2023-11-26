using System;
using System.Collections.Generic;

namespace _08Dictionaries_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings linked to numbers
            Dictionary<int, string> str = new Dictionary<int, string>();
            str.Add(8, "hello");
            str.Add(3, "my");
            str.Add(2, "name");
            str.Add(66, "is");
            str.Add(17, "Anthony");

            //print keys
            foreach (int key in str.Keys)
            {
                Console.WriteLine(key);
            }

            //print values
            foreach (string value in str.Values)
            {
                Console.WriteLine(value);
            }

            //print pairs and add new line for each new pair
            foreach (var pair in str)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }


            //print pairs using elementAt
            for (int i = 0; i < str.Count; i++)
            {
                Console.WriteLine(str.ElementAt(i));
            }
            Console.WriteLine();

            //another way of adding elements with its key
            str[88] = "Coppens";

            foreach (var pair in str)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //removing elements
            str.Remove(88);
            str.Remove(17, out string name);
            Console.WriteLine(name);

            foreach (var pair in str)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //print value linked to a key if it exists
            if (str.ContainsKey(3))
            {
                Console.WriteLine(str[3]);
            }
            Console.WriteLine();



            //dictionary with strings linked to doubles
            Dictionary<string, double> Dstrings = new Dictionary<string, double>
            { { "a", 7.2}, {"b", 3.9 },{"c", 4.5 } };

            foreach (var pair in Dstrings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            Dstrings.Add("hello", 99.9);
            Dstrings.Add("z", 102.7);
            Dstrings.Add("newNumber", 567.8);

            foreach (var pair in Dstrings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();

            Dstrings["a"] = 2.7;
            Dstrings["doesntexistyet"] = 6.476;
            Dstrings["newNumber"] = 5;

            foreach (var pair in Dstrings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            Dstrings.Remove("b");
            Dstrings.Remove("newNumber", out double removedNumber);
            Console.WriteLine(removedNumber);

            foreach (var pair in Dstrings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();



            //can also match the same datatype for key and value
            Dictionary<double, double> D = new Dictionary<double, double>();
            D.Add(2.7, 3.8);
            D.Add(9.1, 4.7);
            D.Add(1.7, 23.9);

            foreach (var pair in D)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();
        }
    }
}