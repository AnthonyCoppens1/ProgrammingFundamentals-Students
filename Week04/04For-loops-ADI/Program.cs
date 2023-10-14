using System;

namespace _04For_loops_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programma dat een getal * ... --> ++
            Console.Write("Geen een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            //idiote versie
            Console.WriteLine($"{getal} * 1 = {getal * 1}");
            Console.WriteLine($"{getal} * 2 = {getal * 2}");
            Console.WriteLine($"{getal} * 3 = {getal * 3}");
            Console.WriteLine($"{getal} * 4 = {getal * 4}");


            //Een veel betere optie:
            Console.WriteLine("\nFOR LOOP i=0; i <= 10 ");
            for (int i = 0; i <= 10; i++)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            Console.WriteLine("\nFOR LOOP i = 1; i <= 10");
            for (int i = 1; i <= 10; i++)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            Console.WriteLine("\nFOR LOOP i = 0; i <= 10; stappen van 2");
            for (  int i = 0; i <= 10; i += 2)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            Console.WriteLine("\nFOR LOOP i = 1; i <= 10; stapgrootte --> *2");
            //PAS OP --> infinite loop als je start bij 0 --> 2 * 0 = 0
            for (int i = 1; i <= 20; i *= 2)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            Console.WriteLine("\nFOR LOOP i = 10; i >= 0; i--");
            //PAS OP for(i = 10; i <= 0; i--) --> geen output

            for (int i = 10; i >= 0; i--) //i = i - 1
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }

            //i = 10 / i = 11 / ... --> infinite loop want i++
            /*for (int i = 10; i >= 0; i++)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }*/


            //print 3 6 9 12 15 18 21 ...
            Console.WriteLine("\n\nVersie 1: sequence 3 6 9 12 ...");
            for (int i = 1; i <= 33; i++)
            {
                int result = i * 3;
                Console.Write(result + " ");
            }
            
            Console.WriteLine("\n\nversie 2: sequence 3 6 9 12 ...");
            for (int i = 3;i < 100; i += 3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nversie 3: sequence 3 6 9 12 ...");
            for (int i = 3; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }


            //geneste for-loop
            Console.Write("\n\nGeef x in: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nGeef y in: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTafel van j");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nTafel van sterren");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nTafel van i's die breder wordt");
            for (int i = 1; i < x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            //Rooster maken van sterren die breder wordt
            for (int i = 1; i <= x; i++)
            {
                for (int z = 0; z < i; z++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}