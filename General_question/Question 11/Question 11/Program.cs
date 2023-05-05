using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter your exchange rate from currency in U.S dollars and Chinese RMB");
            
            double exchange =double.Parse(Console.ReadLine());


            Console.WriteLine("Enter  (0) to convert from  U.S dollars to Chinese RMB and (1) to convert from chinese RMB and U.S dollars.\n");

            string answer = Console.ReadLine();

            if (answer=="0")
            {
                Console.WriteLine("enter your U.S dollars to chinese RMB ");
                double usdollar = int.Parse(Console.ReadLine());

                double rmb = exchange * usdollar;

                Console.WriteLine($"Your amount in U.S dollars to chinese RMB is {rmb}");
            }


            else if (answer=="1")
            {
                Console.WriteLine("enter your chinese RMB to U.S dollars ");
                double chinesermb = int.Parse(Console.ReadLine());

                double Us = chinesermb/exchange;

                Console.WriteLine($"Your amount in chinese RMB  to U.S dollars  is {Us}$ ");
            }



        }
    }
}
