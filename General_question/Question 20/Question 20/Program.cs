using System;

namespace Question_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int count = 0;

            for (int a = 1; a < 500; a++)
            {
                for (int b = a; b <= 500; b++)
                {
                    for (int c = a; c <= 500; c++)
                    {
                        if ((a * a) + (b * b) == (c * c))
                        {
                            Console.WriteLine("The Pythagorean triples are: " + "{" + a + "," + b + "," + c + "}");

                            count++;

                            Console.Write(count);
                        }

                    }



                }

            }
        }
    }
}
