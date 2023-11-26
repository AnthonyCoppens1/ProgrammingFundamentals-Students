using System;
using System.Collections.Generic;

namespace _08Dictioaries_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings linken met getallen
            Dictionary<int, string> S = new Dictionary<int, string>();

            S.Add(8, "Hallo");
            S.Add(3, "Deur");
            S.Add(2, "Naam");
            S.Add(66, "Bank");
            S.Add(17, "Paraplu");

            //print alle keys
            foreach (int key in S.Keys)
            {
                Console.WriteLine(key);
            }

            //print alle values
            foreach (string value in S.Values)
            {
                Console.WriteLine(value);
            }

            //print pairs
            foreach (var pair in S)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }

            //andere manier voor paren te printen
            for (int i = 0; i < S.Count; i++)
            {
                Console.WriteLine(S.ElementAt(i));
            }
            Console.WriteLine();


            //andere manier om elementen toe te voegen met key
            S[88] = "Regen";

            foreach (var pair in S)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //elementen verwijderen
            S.Remove(88);
            S.Remove(17, out string obj);
            Console.WriteLine(obj);

            
            if (S.ContainsKey(3))
            {
                Console.WriteLine(S[3]);
            }
            Console.WriteLine();




            foreach (var pair in S)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //andere soorten dictionaries
            Dictionary<string, double> DoubleDictionary = new Dictionary<string, double> 
            { { "a", 2.1 }, { "b", 7.2 }, { "c", 4.5 } };

            DoubleDictionary.Add("computer", 99.9);
            DoubleDictionary.Add("newNumber", 567.8);

            foreach (var pair in DoubleDictionary)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //DoubleDictionary.Add("a", 3.2); --> nooit dezelfde key gebruiken
            //overschrijven is wel mogelijk
            DoubleDictionary["a"] = 2.7;
            DoubleDictionary["doesntexistyet"] = 6.47;

            foreach (var pair in DoubleDictionary)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //verwijderen van elementen
            DoubleDictionary.Remove("b");
            DoubleDictionary.Remove("newNumber", out double removedDouble);
            Console.WriteLine(removedDouble);

            foreach (var pair in DoubleDictionary)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //zelfde key en value --> datatype
            Dictionary<double,double> D = new Dictionary<double,double>();
            D.Add(2.7, 8.1);
            D.Add(9.1, 4.7);
            D.Add(1.7, 23.9);

            for (int i = 0; i < D.Count; i++)
            {
                Console.WriteLine(D.ElementAt(i));
            }
        }
    }
}