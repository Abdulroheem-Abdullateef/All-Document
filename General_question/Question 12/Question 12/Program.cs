using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the sum of this integers between 1 to 100");

            Random rmd1 = new Random();
            int random1 = rmd1.Next(0, 100);


            Random rmd2 = new Random();
            int random2 = rmd2.Next(0, 100);



            int value = random1 + random2;

            Console.WriteLine($"The sum of {random1} + {random2} is ? ");



            int sum = int.Parse(Console.ReadLine());

            if (sum==value)
            {
                Console.WriteLine("correct");
            }

            else
            {
                Console.WriteLine(" incorrect ");
                Console.WriteLine($"The sum to the two number is {value}");
            }
           
        }
    }
}
