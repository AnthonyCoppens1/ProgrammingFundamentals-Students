using System;
using System.Collections.Generic;

namespace _08Lists_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D array --> vaste lengte
            int[] N = new int[5];
            N[0] = 5;
            N[1] = 10;
            N[2] = 15;
            N[3] = 20;
            N[4] = 25;



            //List met variabele lengte
            List<int> intLIST = new List<int>();

            intLIST.Add(5);
            intLIST.Add(10);
            intLIST.Add(15);
            intLIST.Add(20);
            intLIST.Add(25);

            //list uitprinten
            for (int i = 0; i < intLIST.Count; i++)
            {
                Console.Write(intLIST[i] + " ");
            }
            Console.WriteLine();


            //getallen plaatsen op bepaalde index --> oude positie schuift op
            intLIST.Insert(2, 12);

            //zelfde getal --> laatste wordt eerst geplaatst op die index, gevolgd door vorig
            intLIST.Insert(4, 21);
            intLIST.Insert(4, 22);


            for (int i = 0; i < intLIST.Count; i++)
            {
                Console.Write(intLIST[i] + " ");
            }
            Console.WriteLine();


            //meerdere elementen toevoegen
            int[] getallen = { 7, 8, 9 };
            intLIST.AddRange(getallen); //1 argument!

            //array in bep locatie zetten
            intLIST.InsertRange(1, getallen);

            foreach (int i in intLIST)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //789 komt 2 keer voor, hoe verwijderen?
            intLIST.Remove(7);
            intLIST.Remove(8);
            intLIST.Remove(9);


            foreach (int i in intLIST)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            intLIST.Add(5);
            //verwijderen op bep locatie
            intLIST.RemoveAt(0);

            foreach (int i in intLIST)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //meerdere manieren om getallen of elementen toe te voegen aan een lijst
            List<int> Z = new List<int> { 1, 5 };

            foreach (int i in Z)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //evidente manier om iets toe te voegen op een bepaalde plaats in bep volgorde
            /*for (int i = 2; i < 5; i++)
            {
                Z.Insert(i-1,i);
            }*/

            //start bij 4, schuift dan op
            for (int i = 4; i > 1; i--)
            {
                Z.Insert(1, i);
            }

            foreach (int i in Z)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            //List van strings
            List<string> str = new List<string> { "één", "twee", "drie" };

            foreach (string i in str)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            str.Add("vier");
            str.Add("vijf");
            str.Insert(0, "nul");

            str.Remove("twee");
            str.RemoveAt(4); //vijf wordt verwijderd

            foreach (string i in str)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //index van een woord zoeken
            int index = str.IndexOf("drie");
            Console.WriteLine(index);


            foreach (string i in str)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            str.Add("één"); //één komt 2 keer voor
            int laatste = str.LastIndexOf("één");
            Console.WriteLine(laatste);

            foreach (string i in str)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //een woord toevoegen en checken of het er in staat --> aanpassingen maken gebaseerd hierop
            str.Add("more");
            if (str.Contains("more"))
            {
                index = str.IndexOf("more");
                str.Insert(index, "thomas");
            }

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();


            //list --> array
            string[] S = str.ToArray();

            //array --> list
            double[] doubles = { 1.2, 2.3, 3.4, 4.5 };
            List<double> doubleList = doubles.ToList();


            //andere soorten lists
            List<bool> B = new List<bool> { true, false, false, false, true, true, false };
            List<char> C = new List<char> { 'a', 'b', 'c', 'd' };
        }
    }
}