using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your num1 ");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your num2 ");
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your num3 ");
            int num3 = int.Parse(Console.ReadLine());


            if (num1>=num3)
            {
                num1 = num1 + num3;
                num3 = num1 - num3;
                num1 = num1 - num3;
                
                
            }
            

            if (num1>=num2)
            {
                num1 = num1 + num2;
                num2 = num1 - num2;
                num1 = num1 - num2;

              
            }


            if (num2>=num3)
            {
                num2 = num2 + num3;
                num3 = num2 - num3;
                num2 = num2 - num3;

                
            }

            
            
                Console.WriteLine($"The sort of the number is num1={num1} , num2={num2} , num3={num3} ");    
            

        }
    }
}
