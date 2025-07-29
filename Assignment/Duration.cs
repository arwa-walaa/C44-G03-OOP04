using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Duration
    {

        #region Part2 Q1
        // Attributes
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int TotalSeconds => Hours * 3600 + Minutes * 60 + Seconds;

        #endregion

        #region Part2 Q2
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

     
        public override bool Equals(object obj)
        {
  
            Duration other = (Duration)obj;
            return Hours == other.Hours &&
                   Minutes == other.Minutes &&
                   Seconds == other.Seconds;
        }

       
        public override int GetHashCode()
        {
            unchecked // Overflow is fine
            {
                int hash = 17;
                hash = hash * 23 + Hours.GetHashCode();
                hash = hash * 23 + Minutes.GetHashCode();
                hash = hash * 23 + Seconds.GetHashCode();
                return hash;
            }
        }

        #endregion

        #region Part2 Q3

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

    
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion

        #region Part2 Q4
        private void Normalize()
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
            if (Seconds < 0)
            {
                Seconds += 60;
                Minutes--;
            }

            Hours += Minutes / 60;
            Minutes %= 60;
            if (Minutes < 0)
            {
                Minutes += 60;
                Hours--;
            }
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(
                d1.Hours + d2.Hours,
                d1.Minutes + d2.Minutes,
                d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return d + new Duration(seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(
                d1.Hours - d2.Hours,
                d1.Minutes - d2.Minutes,
                d1.Seconds - d2.Seconds);
        }

        public static Duration operator ++(Duration d)
        {
            // Create new object with modified values
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            // Create new object with modified values
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        public static bool operator >(Duration d1, Duration d2) => d1.TotalSeconds > d2.TotalSeconds;
        public static bool operator <(Duration d1, Duration d2) => d1.TotalSeconds < d2.TotalSeconds;
        public static bool operator >=(Duration d1, Duration d2) => d1.TotalSeconds >= d2.TotalSeconds;
        public static bool operator <=(Duration d1, Duration d2) => d1.TotalSeconds <= d2.TotalSeconds;
        public static bool operator true(Duration d) => d.TotalSeconds != 0;
        public static bool operator false(Duration d) => d.TotalSeconds == 0;

        public static explicit operator DateTime(Duration d)
        {
            DateTime now = DateTime.Now;
            return new DateTime(now.Year, now.Month, now.Day, d.Hours, d.Minutes, d.Seconds);
        }




        #endregion

    }
}
