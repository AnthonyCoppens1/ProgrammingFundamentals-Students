using System;

namespace _11OO_RGB_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RGB kleur = new RGB();
            kleur = kleur.Random();
            Console.WriteLine(kleur.ToString());

            RGB grey = kleur.GreyScale();
            Console.WriteLine(grey.ToString());

            RGB invert = kleur.Inverse();
            Console.WriteLine(invert.ToString());
        }
    }
}