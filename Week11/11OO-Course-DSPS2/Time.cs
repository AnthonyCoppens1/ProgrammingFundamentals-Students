﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_Course_DSPS2
{
    public class Time
    {
        int HH;
        int MM;

        public int Hours
        {
            get
            {
                return HH;
            }
            set
            {
                if ((value >= 0) && (value <= 23))
                {
                    HH = value;
                }
            }
        }

        public int Minutes
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

        public Time (int h, int m)
        {
            Hours = h;
            Minutes = m;
        }

        public Time (Time t, int add)
        {
            Hours = t.Hours + add;
            Minutes = t.Minutes;
        }

        public override string ToString()
        {
            return Hours + ":" + Minutes;
        }
    }
}
