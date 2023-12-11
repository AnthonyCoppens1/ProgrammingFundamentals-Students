using System;

namespace _11OO_RGB_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RGB rgb = new RGB();
            Console.WriteLine(rgb.ToString());
            RGB grey = rgb.GreyScale();
            Console.WriteLine(grey.ToString());
            RGB invert = rgb.Invert();
            Console.WriteLine(invert.ToString());
        }
    }
}