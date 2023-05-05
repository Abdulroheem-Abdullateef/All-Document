using System;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your investment amount");
            int investment = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your annual interest rate ");
            int annualrate = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your number of years  ");
            int years = int.Parse(Console.ReadLine());


            int future = investment * (1 + annualrate) ^ years;

            Console.WriteLine($"Your future investment is {future}");

        }
    }
}
