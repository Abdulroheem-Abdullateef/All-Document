using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a monthtly saving amount ");
            double amount = double.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                amount = amount + 100 * (1 + 0.00417);

            }

            Console.WriteLine($" The amount is {amount}");        
        }

    }
}
