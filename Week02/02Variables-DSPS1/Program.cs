using System;
using System.Runtime.Serialization;

namespace _02Variables_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = 
                new System.Globalization.CultureInfo("en-US");

            int x, y; //Declaring --> group of the same type
            x = 5;      //Initialize --> giving it value
            y = 8;

            byte numberByte = 12;
            //numberByte = 256; Too big, byte is too small

            double numberDouble = 45.897676352;
            // numberFloat = numberDouble; --> double is bigger than float

            float getal = 31.27f; // add f to specify a floating point number

            double som = numberDouble + getal;
            Console.WriteLine(som);


            Console.WriteLine(numberByte);
            Console.WriteLine(numberDouble);

            string name = "Adrian";
            char character = 'z';

            Console.WriteLine(name);
            Console.WriteLine(character);


            //addition and subtraction ++ and --

            Console.WriteLine("x = " + x);
            x++; //x = x + 1
            Console.WriteLine("x = " + x);
            x--; //x = x - 1
            Console.WriteLine("x = " + x);


            //postfix and prefix
            Console.WriteLine($"x++ results in {x++}");
            Console.WriteLine($"x++ results in {++x}");

            Console.WriteLine($"x++ results in {x--}");
            Console.WriteLine($"x++ results in {--x}");


            //arithemic operators
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");

            Console.WriteLine($"5.0 / {y} = {5.0 / y}");


            //modulo %
            Console.WriteLine($"10 % 9 = {10 % 9}"); // 10 / 9 = 1 --> remainder = 1
            Console.WriteLine($"10 % 8 = {10 % 8}"); // 10 / 8 = 1 --> remainder = 2
            Console.WriteLine($"10 % 7 = {10 % 7}"); // 10 / 7 = 1 --> remainder = 3
            Console.WriteLine($"10 % 6 = {10 % 6}"); // 10 / 6 = 1 --> remainder = 4
            Console.WriteLine($"10 % 5 = {10 % 5}"); // 10 / 5 = 2 --> remainder = 0
            Console.WriteLine($"10 % 4 = {10 % 4}"); // 10 / 4 = 2 --> remainder = 2
            Console.WriteLine($"10 % 3 = {10 % 3}"); // 10 / 3 = 3 --> remainder = 1
            Console.WriteLine($"10 % 2 = {10 % 2}"); // 10 / 2 = 5 --> remainder = 0
            Console.WriteLine($"10 % 1 = {10 % 1}"); // 10 / 1 = 10 -- remainder = 0


            //modulo without % operator
            int resultAfterDivision = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultAfterDivision * 3)}");


            //compound operators
            Console.WriteLine("x starts at " + x);
            x += 10; //x = x + 10
            Console.WriteLine("x += 10 --> " + x);

            x -= 7; //x = x - 7
            Console.WriteLine("x -= 7 --> " + x);

            x *= 4; //x = x * 4
            Console.WriteLine("x *= 4 --> " + x);

            x /= 3; //x = x / 3
            Console.WriteLine("x /= 3 --> " + x);

            x %= 5; //x = x % 5
            Console.WriteLine("x %= 5 --> " + x);



            //compound operator --> strings
            name = "Anthony";
            name += " Coppens"; //add it to the back += --> name = name + "Coppens"
            Console.WriteLine(name);


            name = "Anthony"; //adding text to the front
            name = "Coppens " + name;
            Console.WriteLine(name);



            //Comparisson operators
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"x < y --> {x < y}");
            Console.WriteLine($"x > y --> {x > y}");
            Console.WriteLine($"x <= y --> {x <= y}");
            Console.WriteLine($"x >= y --> {x >= y}");
            Console.WriteLine($"x == y --> {x == y}");
            Console.WriteLine($"x != y --> {x != y}");


            //WEIRD THINGS --> DANGER CASES
            Console.WriteLine(5 + 5); //10
            Console.WriteLine("5" + 5); //55
            Console.WriteLine('5' + 5); //58
            Console.WriteLine('5' + '5'); //106
            Console.WriteLine("" + 5 + 5); //55
            Console.WriteLine("" + (5 + 5)); //10


            //characters in a string
            name = "Elizabeth";
            //option 1
            char firstChar = name[0];
            Console.WriteLine($"First character of {name} is {firstChar}");

            //option 2
            firstChar = name.ElementAt(0);
            Console.WriteLine($"First character of {name} is {firstChar}");

            //last character in a string
            char lastChar = name[name.Length - 1];
            Console.WriteLine(name.Length); //--> check length --> seems longer than name
            Console.WriteLine(lastChar);




















        }
    }
}