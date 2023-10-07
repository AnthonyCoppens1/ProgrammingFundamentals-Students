using System;

namespace _03IF_Statement_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = 
                new System.Globalization.CultureInfo("en-US");

            //getal opvragen en controleren

            Console.Write("Geef een getal: ");

            int getal = Convert.ToInt32(Console.ReadLine());

            if (getal < 50)
            {
                Console.WriteLine("Het getal is kleiner dan 50!");
            }
            else if (getal == 50)
            {
                Console.WriteLine("Het getal is gelijk aan 50!");
            }
            else
            {
                Console.WriteLine("Het getal is groter dan 50!");
            }


            //ALTIJD ELSE TOEVOEGEN om if-statement af te sluiten
            if (getal < 50)
            {
                Console.WriteLine("Getal is kleiner dan 50");
            }
            if (getal == 50) //nieuw statement en geen deel van de lijnen hierboven
            {
                Console.WriteLine("Getal is gelijk aan 50");
            }
            else
            {
                Console.WriteLine("Getal is groter dan 50");
            }


            //OPTIE 2
            if (getal < 50)
            {
                Console.WriteLine("kleiner dan 50");
            }
            else
            {
                if (getal == 50)
                {
                    Console.WriteLine("gelijk aan 50");
                }
                else
                {
                    Console.WriteLine("Groter dan 50");
                }
            }


            //optie 3 --> combineren van if's
            if (getal != 50) //verschillend van 50
            {
                if (getal < 50)
                {
                    Console.WriteLine("Kleiner dan 50");
                }
                else
                {
                    Console.WriteLine("Groter dan 50");
                }
            }
            else //Dus uitvoeren als getal wel exact 50 is.
            {
                Console.WriteLine("Gelijk aan 50");
            }


            //optie 4: if in een else versie 2
            if (getal > 50)
            {
                Console.WriteLine("Groter dan 50");
            }
            else
            {
                if (getal == 50)
                {
                    Console.WriteLine("Gelijk aan 50");
                }
                else
                {
                    Console.WriteLine("Kleiner dan 50");
                }
            }



            //voorwaarden combineren --> && || !
            //controleren of een getal (niet) gelijk is aan 50
            //optie 1
            if (getal == 50)
            {
                Console.WriteLine("Getal is 50");
            }
            else
            {
                Console.WriteLine("Getal is niet gelijk aan 50");
            }


            //optie 2
            if (getal < 50 || getal > 50) //1 vd 2 voorwaarden moet maar terugkeren als True
            {
                Console.WriteLine("Getal is NIET gelijk aan 50");
            }
            else
            {
                Console.WriteLine("Getal is 50");
            }


            //optie 3
            if (getal != 50)
            {
                Console.WriteLine("Getal is niet gelijk aan 50");
            }
            else
            {
                Console.WriteLine("Getal is 50");
            }


            //optie 4
            if (!(getal == 50))
            {
                Console.WriteLine("Getal is niet gelijk aan 50");
            }
            else
            {
                Console.WriteLine("Getal is 50");
            }


            //optie 5
            if (getal == 50 && !(getal != 50))
            {
                Console.WriteLine("Getal is gelijk aan 50");
            }
            else
            {
                Console.WriteLine("Getal is NIET gelijk aan 50");
            }


            //optie 6
            bool condition = getal != 50;
            if (condition) //condition == True --> controleren
            {
                Console.WriteLine("Getal is niet gelijk aan 50");
            }
            else
            {
                Console.WriteLine("Getal is 50");
            }


            //optie 7
            if (!condition)
            {
                Console.WriteLine("Getal is 50");
            }
            else
            {
                Console.WriteLine("Getal is niet gelijk aan 50");
            }


            //voorbeeld van alle theorie
            int x = 500;

            if (x > 0 && x < 100)
            {
                Console.WriteLine("Wat een groot getal");
            }
            else if (x == 0 || x < 0 || x >= 100)
            {
                Console.WriteLine("Een beetje kleiner");
            }
            else
            {
                Console.WriteLine("?");
            }






        }
    }
}