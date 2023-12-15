using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_Lesrooster_ADI
{
    public class Time
    {
        int UU;
        int MM;

        public int Uren
        {
            get
            {
                return UU;
            }
            set
            {
                if((value >= 0) && (value <= 23))
                {
                    UU = value;
                }
            }
        }
        public int Minuten
        {
            get
            {
                return MM;
            }
            set
            {
                if ((value >= 0) && (value <= 59))
                {
                    MM = value;
                }
            }
        }

        public Time(int u, int m)
        {
            Uren = u;
            Minuten = m;
        }

        public Time(Time t, int add)
        {
            Uren = t.Uren + add;
            Minuten = t.Minuten;
        }

        public override string ToString()
        {
            return Uren + ":" + Minuten;
        }
    }
}
