using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_Courses_DSPS1
{
    public class Course
    {
        public string Name { get; set; }
        public Teacher Lector { get; set; }
        public string Room { get; set; }
        public int Hours { get; set; }
        public WeekDays Weekday { get; set; }
        public Time StartHour {get; set;}

        public enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }

        public Course(string name, Teacher t, string room, int hours, WeekDays w, Time d)
        {
            Name = name; Lector = t; Room = room; Hours = hours; Weekday = w; StartHour = d;
        }

        public override string ToString()
        {
            string s = "";
            s += "Course: " + Name;
            s += "\n*" + Lector.Name;
            s += "\n*" + Room;
            s += "\n*" + Weekday;
            Time EndHour = new Time(StartHour, Hours);
            s += "\n*" + StartHour.ToString() + "-->" + EndHour.ToString();
            s += "\n";
            return s;
        }
    }
}
