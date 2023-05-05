
using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your GCD number ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your GCD number ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Gcd(number,number2));
            
            







            static int Gcd(int gcd1,int gcd2)
            {
                int max = 0;
                int minimum = Math.Min(gcd1,gcd2);
                for (int i = 1; i < minimum; i++)
                {
                    if (gcd1 % i ==0  && gcd2 % i == 0)
                    {
                        if(i > max) 
                        {
                            max = i;
                        }
                    }

                    

                    
                }
                return max;
                
            }

        }
    }
}
