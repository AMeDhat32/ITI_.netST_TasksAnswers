using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Clock
    {
        private int hours, minutes, seconds;

        
        public Clock(int seconds)
        {
            this.hours = seconds / 3600;
            this.minutes = (seconds % 3600) / 60;
            this.seconds = (seconds % 3600) % 60;
        }

        
        public int Hours { get => hours; set => hours = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }


        public static Clock operator +(Clock c1, Clock c2)
        {
            Clock c3 = new Clock(0);
            c3.hours = c1.hours + c2.hours;
            c3.minutes = c1.minutes + c2.minutes;
            c3.seconds = c1.seconds + c2.seconds;

            if (c3.seconds >= 60)
            {
                c3.minutes += c3.seconds / 60;
                c3.seconds = c3.seconds % 60;
            }

            if (c3.minutes >= 60)
            {
                c3.hours += c3.minutes / 60;
                c3.minutes = c3.minutes % 60;
            }

            return c3;
        }
        public static Clock operator +(Clock c1, Clock c2)
        {
            int totalSeconds = (c1.hours * 3600 + c1.minutes * 60 + c1.seconds) + (c2.hours * 3600 + c2.minutes * 60 + c2.seconds);
            Clock c3 = new Clock(totalSeconds);
            return c3;
        }
     
        public static Clock operator -(Clock c1, Clock c2)
        {
            int totalSeconds = (c1.hours * 3600 + c1.minutes * 60 + c1.seconds) - (c2.hours * 3600 + c2.minutes * 60 + c2.seconds);
            Clock c3 = new Clock(totalSeconds);
            return c3;
        }
       
        public static Clock operator ++(Clock c1)
        {
            c1.minutes++;
            return c1;
        }
        
        public static Clock operator --(Clock c1)
        {
            c1.minutes--;
            return c1;
        }
      
        public static bool operator >(Clock c1, Clock c2)
        {
            return c1.hours * 3600 + c1.minutes * 60 + c1.seconds > c2.hours * 3600 + c2.minutes * 60 + c2.seconds;
        }
        
        public static bool operator <=(Clock c1, Clock c2)
        {
            return c1.hours * 3600 + c1.minutes * 60 + c1.seconds <= c2.hours * 3600 + c2.minutes * 60 + c2.seconds;
        }
        
        public static implicit operator DateTime(Clock c1)
        {
            return new DateTime(1, 1, 1, c1.hours, c1.minutes, c1.seconds);
        }





       
        public override string ToString()
        {
            string time = "";

            if (hours > 0)
            {
                time += " Hours : " + hours;
                time += ", Minutes : " + minutes;
                time += ", Seconds : " + seconds;
            }
            else if (minutes > 0)
            {
                time += " Minutes : " + minutes;
                time += ", Seconds : " + seconds;
            }
            else if (seconds > 0)
            {
                time += " Seconds : " + seconds;
            }
            else if (seconds == 0)
            {
                time += " Time is 0";
            }


            return time;
        }

    }
}
