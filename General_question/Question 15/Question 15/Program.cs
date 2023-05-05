using System;

namespace Question_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your minutes");
            int minutes = int.Parse(Console.ReadLine());


            int year = 60 * 24 * 365;

            int day = 60 * 24;

            int minutesinyear = minutes / year;

            int minutesinday = minutes / day;

            Console.WriteLine($"The number of the years is {minutesinyear} and days is {minutesinday}");
        }
    }
}
