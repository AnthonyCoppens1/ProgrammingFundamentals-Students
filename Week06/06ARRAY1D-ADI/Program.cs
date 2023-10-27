using System;

namespace _06ARRAY1D_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //een array aanmaken
            int[] intArray = new int[10]; //alle waarden zijn 0
            string[] stringArray = new string[4]; //alle waarden ""

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);

            int[] ints = { 1, 3, 8, 23, 99 };

            //waarden achterhalen van bepaalde plekken in array
            Console.WriteLine("Eerste element van intArray: " + intArray[0]);
            Console.WriteLine($"Laatste element van doubles: {doubles[5]}");
            Console.WriteLine($"Laatste element van doubles: {doubles[doubles.Length - 1]}");
            Console.WriteLine($"Laatste element van doubles: {doubles[^1]}");
            Console.WriteLine($"Laatste element van doubles: {doubles[^2]}");

            //^start met tellen vanaf het einde --> ^1 is laatste element, ^2, voorlaatste, ...

            //Waarden koppelen aan arrays
            stringArray[0] = "Dean";
            stringArray[1] = "Tom";
            stringArray[3] = "Jana";
            stringArray[2] = "Mustafa";

            //stringArray[4] = "New guy"; --> index out of range want er zijn maar 4 plaatsen

            Console.WriteLine($"Laatste element van doubles: {doubles[^1]}");
            doubles[5] = 1.0;
            Console.WriteLine($"Laatste element van doubles: {doubles[^1]}");

            //door array loopen

            foreach (var item in stringArray) //gebruik wanneer je niet geeft om index of hoeveel elementen getoond worden
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (string s in stringArray) 
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();

            //loopen wanneer je wel de index nodig hebt.

            for (int i = 0; i < doubles.Length; i++) //van index 0 - 5
            {
                Console.WriteLine(doubles[i]);
            }
            
            for (int i = doubles.Length-1; i >= 0; i--) //van index 5 - 0
            {
                Console.WriteLine(doubles[i]);
            }


            //!!!!!!!!NOOIT GEBRUIKEN AUB!!!!!!! --> WHILE
            int index = 0;
            while (index < doubles.Length)
            {
                Console.WriteLine(doubles[index]);
                index++; //als je dit niet doet, infinite loop
            }


            //een hele array overschrijven.
            doubles = new double[] { 1, 3, 4, -1, -4, 55, 8, 89 };

            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            //array opvullen met for-loop
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 4;
                //vullen met user input
                //Console.Write($"Geef een getal voor index{i}: ");
                //intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int INTEGER in intArray)
            {
                Console.Write(INTEGER + " ");
            }

            Console.WriteLine();

            //array vullen met split-methode
            Console.WriteLine("Geef dieren in, gesplitst met een spatie: ");
            string antwoord = Console.ReadLine(); //"cheetah leeuw kat hond dolfijn"

            string[] dieren = antwoord.Split(' ');
            foreach (var item in dieren)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Geef dieren in, gesplitst met een ;: ");
            antwoord = Console.ReadLine(); //"cheetah leeuw kat hond dolfijn"

            dieren = antwoord.Split(';');
            foreach (var item in dieren)
            {
                Console.WriteLine(item);
            }



            //array vullen en omzetten met de split-methode
            Console.WriteLine("Geef getallen in, gesplitst met een spatie: ");
            antwoord = Console.ReadLine(); //"8 9 12 3 -5 7 99 308 12345"
            string[] strArray = antwoord.Split(' ');
            int[] arrayOfInts = new int[strArray.Length];

            for (int i = 0; i < arrayOfInts.Length; i++) //OF strArray.Length
            {
                arrayOfInts[i] = Convert.ToInt32(strArray[i]);
            }

            foreach(var item in arrayOfInts)
            {
                Console.WriteLine(item);
            }

            //of omzetten in 1 keer

            arrayOfInts = Array.ConvertAll(strArray, Convert.ToInt32);

        }
    }
}