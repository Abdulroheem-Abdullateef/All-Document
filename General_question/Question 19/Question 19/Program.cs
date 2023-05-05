using System;

namespace Question_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your total miles driven per day");
            double totalmiles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your cost per gallon of gasoline(in cents)");
            double costpergallon = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Average miles per gallon");
            double averagemiles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your parking fees per day(in cents) ");
            double parkingfees = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your tolls per day (in cents)");
            double tollsperday = double.Parse(Console.ReadLine());

            double DDCcarpool = (totalmiles / averagemiles) * costpergallon + parkingfees + tollsperday;

            Console.WriteLine($" The calculation of car pool is {DDCcarpool}");

        }
    }
}
   