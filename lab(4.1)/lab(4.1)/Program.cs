using System;
namespace lab_4._1_

{
    class Program
    {
        static void Main(string[] args)
        {
            Hour hour = new Hour(10);
            Minute minute = new Minute(30);
            Time currentTime = new Time(hour, minute);
            Daytime daytime = new Daytime(currentTime);
            Console.WriteLine("Поточний час");
            daytime.GetCurrentTime();
            Console.WriteLine("Пора доби");
            daytime.CalculateDaytime();

        }
    }
}