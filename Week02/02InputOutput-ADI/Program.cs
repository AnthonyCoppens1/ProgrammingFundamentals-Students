using System;

namespace _02InputOutput_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input en output met vervolg van conversion (omzetten)

            Console.Write("Enter your name: ");
            string naam = Console.ReadLine();
            Console.WriteLine(naam);


            //conversion - het omzetten van datatypes
            Console.Write("Enter a number: ");
            string antwoord = Console.ReadLine();
            int getal = Convert.ToInt32(antwoord);
            Console.WriteLine(getal);

            //int antwoord = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a byte: ");
            antwoord = Console.ReadLine();
            byte b = Convert.ToByte(antwoord);
            Console.WriteLine(b);

            Console.Write("Enter a short: ");
            short s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(s);

            //int16 = short / int32 = int / int64 = long
            
            Console.WriteLine(s); //impliciete omzetting --> computer zet zelf short om naar string
            Console.WriteLine(s.ToString()); //expliciete 

            Console.Write("Enter a character: ");
            char c = Convert.ToChar(Console.ReadLine());
            //int getalvanC = c;

            Console.WriteLine(c);
            Console.WriteLine((int)c); //cast char c to an int
            //Console.WriteLine(getalvanC);

            //int nameToNumber = (int)naam; //never works
            //int stringNumber = (int)"89"; //Werkt ook nooit
            getal = (int)78.89893;
            Console.WriteLine(getal);

            double doubleNumber = (double)78;
            Console.WriteLine(doubleNumber);

        }
    }
}