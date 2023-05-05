using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your edge1");
            int edges1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your edge2");
            int edges2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your edge3");
            int edges3 = int.Parse(Console.ReadLine());

            int sum1 = edges1 + edges2;

            int sum2 = edges2 + edges3;

            int sum3 = edges3 + edges1;

            if (sum1>edges3&&sum2>edges1&&sum3>edges2)
            {
                Console.WriteLine(" your input is valid");
                
            }

            else
            {
                Console.WriteLine(" your input is invalid");
            }
        }
    }
}
