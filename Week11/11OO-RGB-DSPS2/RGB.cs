using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_RGB_DSPS2
{
    public class RGB
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public Random r;

        public RGB()
        {
            r = new Random();
            R = (byte)r.Next(0, 256);
            G = (byte)r.Next(0, 256);
            B = (byte)r.Next(0, 256);
        }

        public RGB GreyScale()
        {
            double greyR = 0.3 * R;
            double greyG = 0.59 * G;
            double greyB = 0.11 * B;
            return new RGB { R = (byte) greyR, G = (byte) greyG, B = (byte) greyB };
        }

        public RGB Invert()
        {
            int invertR = 255 - R;
            int invertG = 255 - G;
            int invertB = 255 - B;
            return new RGB { R = (byte) invertR, G = (byte)invertG, B = (byte)invertB};
        }

        public override string ToString()
        {
            return $"RBG ({R}, {G}, {B})";
        }
    }
}
