using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Duration
    {
        // Attributes
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        // 1. Override ToString() to display duration in HH:MM:SS format
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

        // 2. Override Equals() for value equality comparison
        public override bool Equals(object obj)
        {
  
            Duration other = (Duration)obj;
            return Hours == other.Hours &&
                   Minutes == other.Minutes &&
                   Seconds == other.Seconds;
        }

        // 3. Override GetHashCode() to maintain hash contract with Equals()
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

    }
}
