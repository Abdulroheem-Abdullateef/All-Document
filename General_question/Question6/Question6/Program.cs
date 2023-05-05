using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your today's of the week between 1 to 7 ");
            int todayweek =int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your number of day's");
            int  days = int.Parse(Console.ReadLine());

            int futuredays = (todayweek + days) % 7;

            if (futuredays==0)
            {
                Console.WriteLine(" Your future day is Sunday");
                
            }

            else if (futuredays==1)
            {
                Console.WriteLine(" Your future day is Monday");
            }

            else if (futuredays==2)
            {
                Console.WriteLine(" Your future day is Tuesday");
            }

            else if (futuredays==3)
            {
                Console.WriteLine(" Your future day is Wednesday");
            }

            else if (futuredays==4)
            {
                Console.WriteLine(" Your future day is Thursday");
            }

            else if (futuredays==5)
            {
                Console.WriteLine(" Your future day is Friday");
            }

            else if (futuredays==6)
            {
                Console.WriteLine(" Your future day is Saturday");
            }
        }
    }
}
