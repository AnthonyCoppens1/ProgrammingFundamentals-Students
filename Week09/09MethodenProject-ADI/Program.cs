using System;
using System.ComponentModel;

namespace _09MethodenProject_ADI
{
    internal class Program
    {
        //static int[] getallen = { 4, 5, 2, 3, 1, 0 };


        static void Main(string[] args)
        {
            HelloWorld();
           
            //5 + 10
            int a = Toevoegen(5,10);
            Console.WriteLine(a + 5);

            int antwoord = Toevoegen(201, 99);
            Console.WriteLine(antwoord);
            Console.WriteLine(Toevoegen(201, 99));

            int[] nrs1 = { 4, 5, 1, 0, 2, 3 };
            Print(nrs1);
            Array.Sort(nrs1);
            Print(nrs1);


            int[] nrs2 = { 2, 4, 6, 10, 8, 9, 1, 3, 5, 7, 2 };
            Print(nrs2);
            Array.Sort(nrs2);
            Print(nrs2);

            //gevuld met random getallen
            int[] nrs3 = Fill(); //niet ingevuld --> optionele waarde van methode
            Print(nrs3);
            Array.Sort(nrs3);
            Print(nrs3);

            int[] nrs4 = Fill(20); //wel ingevuld --> vaste waarden die tussen () staat
            Print(nrs4);
            Array.Sort(nrs4);
            Print(nrs4);

            string[] woorden = { "banaan", "appel", "citroen" };
            Print(woorden);
            Array.Sort(woorden);
            Print(woorden);

            double[] D = { 1.2,2.5,1.01 };
            Print(D);
            Array.Sort(D);
            Print(D);


            //pass by value
            int scoreStudent = 75;
            Console.WriteLine($"Score van student VOOR extra punten: {scoreStudent}");
            GEEFMIJPUNTEN(ref scoreStudent);
            Console.WriteLine($"Score van student NA extra punten: {scoreStudent}");


            //pass by reference
            int[] scores = new int[1];
            scores[0] = 80;
            Console.WriteLine($"Score van student VOOR extra punten: {scores[0]}");
            GEEFMIJPUNTENARRAY(scores);
            Console.WriteLine($"Score van student NA extra punten: {scores[0]}");


            int c = 6;
            int d = 8;
            Console.WriteLine($"c: {c} en d: {d}");
            SwapValue(c, d);
            Console.WriteLine($"c: {c} en d: {d}");

            //out met de oude manier
            Console.Write("Geef een grootte in van een array: ");
            string antw = Console.ReadLine();
            int size;
            int[] ARRAY;
            if (Int32.TryParse(antw,out size))
            {
                ARRAY = Fill(size);
            }
            else
            {
                ARRAY = Fill();
            }
            Print(ARRAY);


            //nieuwe manier met out
            int add;
            int mult;
            ADDandMULT(5, 10, out add, out mult);
            Console.WriteLine(add);
            Console.WriteLine(mult);


            AddValues(5);
            AddValues(5, z: 2);


            //params keyword
            int[] mijnArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(mijnArray);

            PrintArray(1, 2, 3, 4, 5, 8, 9, 10, 12, 24, 58);

        }

        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void AddValues(int x, int y = 1, int z = 7)
        {
            int antwoord = x + y + z;
            Console.WriteLine(antwoord);

        }

        static void ADDandMULT(int a, int b, out int added, out int multiplied)
        {
            added = a + b;
            multiplied = a * b;
        }

        static (int,int) SwapValue(int c, int d)
        {
            int temp = c;
            c = d;
            d = temp;
            return (c, d);
        }

        static void GEEFMIJPUNTENARRAY(int[] scores)
        {
            scores[0] += 3;
        }

        static void GEEFMIJPUNTEN(ref int N)
        {
            N += 3;
        }

        static int[] Fill(int size = 10)
        {
            Random rd = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-20,21);
            }
            return array;

            //Array.Sort(array); --> DODE CODE WANT NA RETURN

        }
        static void Print(string[] W)
        {
            foreach (var item in W)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(double[] doubles)
        {
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(int[] getallen)
        {
            foreach (var item in getallen)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int Toevoegen(int getal1, int getal2)
        {
            int antwoord = getal1 + getal2;
            return antwoord;
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}