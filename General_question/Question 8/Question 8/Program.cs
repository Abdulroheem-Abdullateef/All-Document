using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a tossing  (0), (1), Did you want to play yes/no ");
            string answer = Console.ReadLine();

            while (answer=="yes")
            {   
                    Random rmd = new Random();
                    int random = rmd.Next(0,2);

                
                Console.WriteLine("Guess a tossing game  ");
                int guess = int .Parse(Console.ReadLine());

                   if (guess==random)
                   {
                   
                    
                    Console.WriteLine($"your guess is correct ");
               
                
                   }    


                    else 
                    {
                        Console.WriteLine($"your guess is incorrect ");
                    }


                Console.WriteLine(" did you want to stop yes/no ");
                string ans = Console.ReadLine();
                if (ans=="yes")
                {
                    break;
                }

            }

        }
    }
}
