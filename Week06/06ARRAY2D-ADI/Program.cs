using System;

namespace _06ARRAY2D_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D array aanmaken
            int[,] ints = new int[4, 5];
            string[,] fruit = { { "appel", "peer", "pompelmoes", "banaan"},
            {"limoen", "watermeloen", "aardbei", "lychee" },
            {"druif", "granaatappel", "perzik", "appelsien" } };

            //waarden opvragen
            //reminder: index start bij 0,0
            Console.WriteLine($"element in rij 1 col 1: {fruit[0, 0]}");
            Console.WriteLine($"element in rij 2 col 2: {fruit[1, 1]}");

            fruit[1, 1] = "citroen";
            Console.WriteLine($"element in rij 2 col 2: {fruit[1, 1]}");

            //loopen door arrays
            Console.WriteLine(fruit.Length);
            Console.WriteLine("# rijen : " + fruit.GetLength(0)); //checkt dimensies van array
            Console.WriteLine("# kol : " + fruit.GetLength(1));

            //rijen
            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for (int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + "\t"); //\t = horizontal tab
                }
                Console.WriteLine();
            }

            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //array opvullen met random getallen en achteraf som berekenen
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++) ///rijen
            {
                for (int j = 0; j < ints.GetLength(1); j++) //kolommen
                {
                    ints[i, j] = rd.Next(0, 21);
                    Console.Write(ints[i,j] + "\t");
                }
                Console.WriteLine();
            }

            int som = 0;
            foreach (var item in ints)
            {
                som += item;
            }
            Console.WriteLine("som: " + som);

        }
    }
}