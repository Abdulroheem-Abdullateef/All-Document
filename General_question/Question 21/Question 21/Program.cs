using System;

namespace Question_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; n < 12000; n=+2)
            {
                Console.WriteLine(n );
            }
        }
    }
}
