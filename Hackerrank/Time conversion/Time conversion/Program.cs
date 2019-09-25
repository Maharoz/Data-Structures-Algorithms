using System;
using static System.Console;

namespace Time_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = ReadLine();
            var amOrPm = time.Substring(8);
            var hourComponent = time.Substring(0, 2);
            var remainingTimeComponent = time.Substring(2, 6);
            if (amOrPm == "AM" && hourComponent == "12")
            {
                hourComponent = "00";
            }
            else if (amOrPm == "PM")
            {
                var numericHourComponent = int.Parse(hourComponent);
                if (numericHourComponent != 12)
                {
                    hourComponent = Convert.ToString(12 + numericHourComponent);
                }
            }
            WriteLine(hourComponent + remainingTimeComponent);
        }
    }
}
