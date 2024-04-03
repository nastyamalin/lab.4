using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._1_
{
    class Daytime
    {
        private Time currentTime;

        public Daytime(Time time)
        {
            currentTime = time;
        }

        public void GetCurrentTime()
        {
            Console.WriteLine($"Поточний час: {currentTime}");
        }

        public string CalculateDaytime()
        {
            int hour = currentTime.Hour.Value;

            if (hour >= 6 && hour < 12)
                return "ранок";
            else if (hour >= 12 && hour < 18)
                return "день";
            else if (hour >= 18 && hour < 24)
                return "вечір";
            else
                return "ніч";
        }

        public override string ToString()
        {
            return $"Пора доби: {CalculateDaytime()}";
        }
    }
}
