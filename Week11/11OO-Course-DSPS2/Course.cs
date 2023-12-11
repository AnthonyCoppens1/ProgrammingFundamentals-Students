namespace _11OO_Course_DSPS2
{
    public class Course
    {
        public string Name { get; set; }
        public Teacher Lector {get; set;}
        public string Room { get; set; }
        public int Hours { get; set; }
        public WeekDays Weekday { get; set; }
        public Time StartHour {get; set;}

        public Course(string name, Teacher t, string room, int hours, 
            WeekDays w, Time D)
        {
            Name = name; Lector = t; Room = room; Hours = hours; Weekday = w;
            StartHour = D;
        }

        public override string ToString()
        {
            string s = "";
            s += "Course: " + Name;
            s += "\n* " + Lector.Name;
            s += "\n* " + Room;
            s += "\n* " + Weekday;
            Time EndHour = new Time(StartHour, Hours);
            s += "\n* " + StartHour.ToString() + "-->" + EndHour.ToString();
            s += "\n";
            return s;
        }


    }




}
