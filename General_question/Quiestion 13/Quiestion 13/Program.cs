using System;

namespace Quiestion_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your balance");
            int balance = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Annual percentage");
            int annualpercentage = int.Parse(Console.ReadLine());

            int interest = 0;
            for (int i = 0; i <= 2; i++)
            {
                interest = (balance * annualpercentage)/1200;


                
            }

            Console.WriteLine($"The interest of the two month {interest}");
        }
        
    }
}
