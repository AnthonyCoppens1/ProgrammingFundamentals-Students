﻿using System;

namespace _01Uppercase_testcase__DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name? ");
            string firstName = Console.ReadLine();
            //firstName = firstName.ToUpper();

            Console.WriteLine("HELLO " + firstName.ToUpper());

            //Console.WriteLine($"HELLO {firstName.ToUpper()}");
            //Console.WriteLine("HELLO {0}", firstName.ToUpper());
        }
    }
}