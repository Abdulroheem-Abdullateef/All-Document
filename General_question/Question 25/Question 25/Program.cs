using System;

namespace Question_25
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Enter your year ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first day of the year");
            int firstday = int.Parse(Console.ReadLine());

            int finalyear = firstday * year % 12;

            int finalday = finalyear % 30;       


    


            string day1 = "Monday";

            string day2 = "Tuesday";

            string day3 = " Wednesday ";

            string day4 = "Thursday";

            string day5 = "Friday";

            string day6 = "Saturday";

            string day7 = "Sunday";


            
            


            if (finalday==finalyear)
            {
                Console.WriteLine($" January 1 , {year} is {day1}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" Febuary 1 , {year} is {day2}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" March 1 , {year} is {day3}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" April 1 , {year} is {day4}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" May 1 , {year} is {day5}");

            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" June 1 , {year} is {day6}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" July 1 , {year} is {day7}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" August 1 , {year} is {day1}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" September 1 , {year} is {day2}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" October 1 , {year} is {day3}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" November 1, {year} is {day4}");
            }

            else if (finalday==finalyear)
            {
                Console.WriteLine($" December 1, {year} is {day5}");
            }
        }
    }
}
