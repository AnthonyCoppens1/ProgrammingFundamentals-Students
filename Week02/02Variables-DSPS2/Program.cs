using System;

namespace _02Variables_DSPS2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //creating variables
            string name = "Anthony";
            char character = 'a';
            name = "another name";

            int x, y; // Declaring our variables --> group same type
            x = 5; //Initialization --> giving it value
            y = 8;

            byte numberByte = 240;
            //numberByte = 256; //too big, byte is smaller, max 255

            double numberDouble = 45.897676352;
            //float numberFloat = numberDouble; --> double is bigger than float, max 7 digits

            float numberFloat = 56.89089f;
            numberDouble = numberFloat; //float in double is possible

            Console.WriteLine(name);
            Console.WriteLine(numberByte);
            Console.WriteLine(numberDouble);
            Console.WriteLine(numberFloat);
            Console.WriteLine(character);


            //addition and subtraction ++ --

            Console.WriteLine("x = " + x);
            x++; //x = x + 1
            Console.WriteLine("x = " + x);
            --x; //x = x - 1
            Console.WriteLine("x = " + x);

            //prefix postfix
            Console.WriteLine($"x++ results in {x++}");
            Console.WriteLine($"This is the curret value of {x}");
            Console.WriteLine($"++x results in {++x}");
            Console.WriteLine($"This is the curret value of {x}");
            Console.WriteLine($"x-- results in {x--}");
            Console.WriteLine($"This is the curret value of {x}");
            Console.WriteLine($"--x results in {--x}");
            Console.WriteLine($"This is the curret value of {x}");


            //arithmetic operators
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"5.0 / {y} = {5.0 / y}");


            //modulo  %
            Console.WriteLine($"10 % 9 = {10 % 9}"); // 10 / 9 = 1 --> remainder = 1
            Console.WriteLine($"10 % 8 = {10 % 8}"); // 10 / 8 = 1 --> remainder = 2
            Console.WriteLine($"10 % 7 = {10 % 7}"); // 10 / 7 = 1 --> remainder = 3
            Console.WriteLine($"10 % 6 = {10 % 6}"); // 10 / 6 = 1 --> remainder = 4
            Console.WriteLine($"10 % 5 = {10 % 5}"); // 10 / 5 = 2 --> remainder = 0
            Console.WriteLine($"10 % 4 = {10 % 4}"); // 10 / 4 = 2 --> remainder = 2
            Console.WriteLine($"10 % 3 = {10 % 3}"); // 10 / 3 = 3 --> remainder = 1
            Console.WriteLine($"10 % 2 = {10 % 2}"); // 10 / 2 = 5 --> remainder = 0
            Console.WriteLine($"10 % 1 = {10 % 1}"); // 10 / 1 = 10 --> remainder = 0



            //modulo without % operator
            int resultAfterDivision = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultAfterDivision * 3)}");


            //compound operators
            Console.WriteLine("x starts at " + x);
            x += 10; // x = x + 10
            Console.WriteLine("x += 10 --> " + x);
            x -= 7; //x = x - 7
            Console.WriteLine("x -= 7 --> " + x);
            x *= 4; //x = x * 4
            Console.WriteLine("x *= 4 --> " + x);
            x /= 3; //x = x / 3
            Console.WriteLine("x /= 3 --> " + x);
            x %= 5; //x = x % 5
            Console.WriteLine("x %= 5 --> " + x);


            //compound operators --> strings
            name = "Anthony";
            name += " Coppens"; //name = name + " Coppens"
            Console.WriteLine(name);

            name = "Anthony";
            name = "Coppens " + name; //add text in front of a string
            Console.WriteLine(name);


            //comparisson operators
            Console.WriteLine($"{x} {y}");
            Console.WriteLine($"x < y --> {x < y}");
            Console.WriteLine($"x > y --> {x > y}");
            Console.WriteLine($"x <= y --> {x <= y}");
            Console.WriteLine($"x >= y --> {x >= y}");
            Console.WriteLine($"x == y --> {x == y}");
            Console.WriteLine($"x != y --> {x != y}");


            //WEIRD THINGS - ATTENTION!

            Console.WriteLine(5 + 5); //10
            Console.WriteLine("5" + 5); //55
            Console.WriteLine('5' + 5); //58 --> ascii value of 5 = 53
            Console.WriteLine('5' + '5'); //106
            Console.WriteLine("" + 5 + 5); //55
            Console.WriteLine("" + (5 + 5)); //10


            //characters in strings

            name = "Elizabeth";
            char firstChar = name[0];
            Console.WriteLine($"First character of {name} is {firstChar}");

            firstChar = name.ElementAt(0);
            Console.WriteLine($"First character of {name} is {firstChar}");

            char lastChar = name[name.Length - 1];
            //Console.WriteLine(name.Length);

            Console.WriteLine($"Last character of {name} is {lastChar}");


        }
    }
}