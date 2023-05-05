using System;

namespace Question_for_Array_Class
{
    class Program
    {
        static void Main(string[] args)
        {
             
            

            int[] odd = new int[5] { 1, 2, 3, 4, 5 };

            int[] even = new int[5] { 2, 4, 8, 10, 12 };

            Console.WriteLine($"The last number in odd is {odd.Length - 1}");
            Console.WriteLine($"The first number in odd is {odd[0]}");
            Console.WriteLine($"The middle number is {odd.Length/2}");



            Console.WriteLine($"The last number in even is {even.Length - 1}");
            Console.WriteLine($"The first number in even is  {even[0]}");
            Console.WriteLine($"The middle number in even  is {even.Length/2-1}");


             

            



        }
    }
}
