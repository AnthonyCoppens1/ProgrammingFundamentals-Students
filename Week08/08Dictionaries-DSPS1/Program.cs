using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _08Dictionaries_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string linked to numbers
            Dictionary<int, string> strings = new Dictionary<int, string>();
            strings.Add(8, "Hello");
            strings.Add(3, "my");
            strings.Add(2, "name");
            strings.Add(66, "is");
            strings.Add(17, "Albert");

            //print keys
            foreach (int key in strings.Keys)
            {
                Console.WriteLine(key);
            }

            //print values
            foreach (string value in strings.Values)
            {
                Console.WriteLine(value);
            }

            //printing pairs
            foreach (var pair in strings)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }

            //another of printing pairs
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings.ElementAt(i));
            }


            //another way of adding elements --> with its key
            strings[88] = "Coppens";

            foreach (var pair in strings)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }


            //removing elements
            strings.Remove(88);
            strings.Remove(17, out string name); //only works if key is an integer
            Console.WriteLine(name);

            //print values linked to a key --> check if it exists
            //check for key
            if (strings.ContainsKey(3))
            {
                Console.WriteLine(strings[3]);
            }

            //check for value
            if (strings.ContainsValue("my"))
            {
            }


            foreach (var pair in strings)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }



            //dictionary with string keys linked to doubles
            Dictionary<string, double> doubles = new Dictionary<string, double> { { "a", 7.2 }, { "b", 3.9 }, { "c", 4.5 } };
            doubles.Add("z", 99.9);
            doubles.Add("hello", 23.8);
            doubles.Add("newNumber", 567.8);

            foreach (var pair in doubles)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }


            //doubles.Add("a", 3.2); --> cannot use the same key
            //but you can overwrite existing keys
            doubles["a"] = 2.7;
            doubles["newNumber"] = 6.47;

            foreach (var pair in doubles)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }
            Console.WriteLine();

            //removing elements
            doubles.Remove("b");
            doubles.Remove("newNumber", out double removedDouble);
            Console.WriteLine(removedDouble);

            foreach (var pair in doubles)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }
            Console.WriteLine();


            //dictionaries that have same datatype for key and value
            Dictionary<double, double> D = new Dictionary<double, double>();
            D.Add(2.7, 3.8);
            D.Add(9.1, 4.7);
            D.Add(1.7, 23.9);

            for (int i = 0; i < D.Count; i++)
            {
                Console.WriteLine(D.ElementAt(i));
            }
        }
    }
}