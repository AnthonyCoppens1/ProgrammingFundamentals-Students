using System;

namespace _02Variabelen_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = 
                new System.Globalization.CultureInfo("en-US");

            string naam = "Anthony";
            naam = "een andere naam";

            char character = 'a';

            int x, y; //Declareren van variabelen --> enkel zelfde type
            x = 5;
            y = 8;

            byte numberByte = 12;
            //numberByte = 256; //waarde is te groot voor byte (0-255)

            double numberDouble = 45.897632452;

            //float numberFloat = numberDouble; //double max 15 getallen na . / float --> 7
            float numberFloat = 56.89089f;

            numberDouble = numberFloat; //float past in double

            Console.WriteLine(naam);
            Console.WriteLine(character);
            Console.WriteLine(numberByte);
            Console.WriteLine(numberDouble);
            Console.WriteLine(numberFloat);
            Console.WriteLine($"x = {x} en y = {y}");


            //optellen en aftrekken
            Console.WriteLine("x = " + x);
            x++;
            Console.WriteLine("x = " + x);
            --x;
            Console.WriteLine("x = " + x);

            //postfix en prefix

            Console.WriteLine($"Startpunt van x = {x}");

            //eerst x printen dan + 1
            Console.WriteLine($"x++ results in {x++}"); //x = x + 1
            Console.WriteLine($"Tussenstand van x = {x}");

            //eerst + 1 dan x printen
            Console.WriteLine($"++x results in {++x}");
            Console.WriteLine($"Tussenstand van x = {x}");

            //eerst x printen dan - 1
            Console.WriteLine($"x-- results in {x--}"); //x = x - 1
            Console.WriteLine($"Tussenstand van x = {x}");

            //eerst -1 dan x printen
            Console.WriteLine($"--x results in {--x}");
            Console.WriteLine($"Eindstand van x = {x}");


            //artithemic operators
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"{5.0} / {y} = {5.0 / y}");


            //module %
            Console.WriteLine($"10 % 9 = {10 % 9}"); //10 / 9 = 1 --> rest = 1
            Console.WriteLine($"10 % 8 = {10 % 8}"); //10 / 8 = 1 --> rest = 2
            Console.WriteLine($"10 % 7 = {10 % 7}"); //10 / 7 = 1 --> rest = 3
            Console.WriteLine($"10 % 6 = {10 % 6}"); //10 / 6 = 1 --> rest = 4
            Console.WriteLine($"10 % 5 = {10 % 5}"); //10 / 5 = 2 --> rest = 0
            Console.WriteLine($"10 % 4 = {10 % 4}"); //10 / 4 = 2 --> rest = 2
            Console.WriteLine($"10 % 3 = {10 % 3}"); //10 / 3 = 3 --> rest = 1
            Console.WriteLine($"10 % 2 = {10 % 2}"); //10 / 2 = 5 --> rest = 10
            Console.WriteLine($"10 % 1 = {10 % 1}"); //10 / 1 = 10 --> rest = 0

            //Modulo zonder moduloteken (%)
            int resultAfterDivision = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultAfterDivision * 3)}");


            //compounds operators
            Console.WriteLine($"x starts at {x}");
            x += 10; //x = x + 10
            Console.WriteLine("x += 10 --> " + x);
            x -= 7; //x = x - 7
            Console.WriteLine("x -= 7 --> " + x);
            x *= 4; //x = x * 4
            Console.WriteLine("x *= 4 --> " + x);
            x /= 3; //x = x / 3
            Console.WriteLine("x /= 3 --> " + x);
            x %= 5;
            Console.WriteLine("x %= 5 --> " + x);


            //Compound operators voor string 
            naam = "Anthony";
            naam += " Coppens"; //naam = naam + "Coppens" --> achteraan toevoegen
            Console.WriteLine(naam);

            naam = "Anthony";
            naam = "Coppens " + naam; //vooraan toevoegen
            Console.WriteLine(naam);


            //comparisson operators (vergelijkingen) True of False
            Console.WriteLine($"{x} {y}");
            Console.WriteLine($"x < y --> {x < y}"); //True
            Console.WriteLine($"x > y --> {x > y}"); 
            Console.WriteLine($"x <= y --> {x <= y}"); 
            Console.WriteLine($"x >= y --> {x >= y}"); 
            Console.WriteLine($"x == y --> {x == y}"); 
            Console.WriteLine($"x != y --> {x != y}");


            //Vreemde toestanden
            Console.WriteLine(5 + 5);       //10
            Console.WriteLine("5" + 5);     //55
            Console.WriteLine('5' + 5);     //58 ascii value van 5 = 53
            Console.WriteLine('5' + '5');   //106 --> 2 keer 53
            Console.WriteLine("" + 5 + 5);  //55
            Console.WriteLine("" + (5 + 5)); //10 --> volgorde van bewerking


            //characters in strings
            naam = "Elizabeth";
            char firstChar = naam[0];
            Console.WriteLine($"Eerste character van {naam} is {firstChar}");

            firstChar = naam.ElementAt(0);
            Console.WriteLine($"Eerste character van {naam} is {firstChar}");

            char laatsteChar = naam[naam.Length - 1];
            Console.WriteLine($"Laatste character van {naam} is {laatsteChar}");

            laatsteChar = naam.ElementAt(naam.Length - 1);
            Console.WriteLine($"Laatste character van {naam} is {laatsteChar}");


            //input en output
            //controleren of een getal kleiner is dan 100 en groter dan 10 MET / of %

            int getal = 55;
            Console.WriteLine(getal > 10 && getal < 100); //&& of AND

            int resultaat = getal / 10;
            Console.WriteLine(resultaat >= 1 && resultaat <= 10);

            int resultaatModulo100 = 100 % getal;
            Console.WriteLine(resultaatModulo100 < 100 && resultaatModulo100 > 10);
        }
    }
}