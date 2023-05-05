using System;

namespace Question_2_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] number = new int[5];
            int largest = 0;
          
            int average = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a scores ");
                number[i] = int.Parse(Console.ReadLine());
                average += number[i];
            }

            int lowest = number[0];
            foreach (var item in number)
            {
                if (item > largest)
                {
                    largest = item;

                }

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              if (lowest > item)
                    if (item<lowest)
                    {
                        lowest = item;
                    }


            }

            int result = average / 5;


            Console.WriteLine($"The largest is {largest} and the lowest is {lowest} and the average is {result}");






            




































        }
    }
}
