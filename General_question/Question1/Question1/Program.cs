using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play= true;
            Console.WriteLine("Guess the number");

            
            while (play)
            {

                Random rmd = new Random();
                int random =rmd.Next(1, 1000);
                
                Console.WriteLine("Guess the number between 1 to 1000 ");
                int guess = int.Parse(Console.ReadLine());

                if (guess > random)
                {
                    Console.WriteLine("To high try again");
                }

                else if (guess < random)
                {
                    Console.WriteLine("To low try again");
                }


                else if (guess == random)
                {
                    Console.WriteLine(" Congratulation. You guessed the number! ");
                }

                Console.WriteLine("To stop type 'stop' or continue ");
                string stop = Console.ReadLine();
                if (stop == "stop")
                {
                    break;
                }

            }



        }
    }
}
