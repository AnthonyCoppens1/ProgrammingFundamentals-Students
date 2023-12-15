using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_RGB_ADI
{
    public class RGB
    {
        public byte R {  get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public Random r;

        public RGB()
        {
            R = 0;
            G = 0;
            B = 0;
        }

        public RGB Random()
        {
            r = new Random();
            R = (byte)r.Next(0, 256);
            G = (byte)r.Next(0, 256);
            B = (byte)r.Next(0, 256);

            return new RGB { R = R, G = G, B = B };
        }

        public RGB GreyScale()
        {
            double doubleR = R * 0.3;
            double doubleG = G * 0.59;
            double doubleB = B * 0.11;

            return new RGB { R = (byte)doubleR, G = (byte)doubleG, B = (byte)doubleB };
        }

        public RGB Inverse()
        {
            return new RGB { R = (byte)(255 - R), G = (byte)(255 - G), B = (byte)(255 - B) };
        }

        public override string ToString()
        {
            return $"RGB ({R},{G},{B})";
        }
    }
}
