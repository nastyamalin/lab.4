using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._1_
{
    class Time
    {
        public Hour Hour { get; }
        public Minute Minute { get; }

        public Time(Hour hour, Minute minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public override string ToString()
        {
            return $"{Hour}:{Minute}";
        }
    }
}
