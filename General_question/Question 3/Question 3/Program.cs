using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your quality point");
            int point = int.Parse(Console.ReadLine());

            

            Console.WriteLine(QualityPoints(point));







            static  int QualityPoints(int num)
            {
                int average = 0;

                if (num<=100&&num>=90)
                {
                    average = 4;
                }
                

                else if (num<=89&&num>=80)
                {
                    average = 3;
                }


                else if (num<=79&&num>=70)
                {
                    average = 2;
                }


                else if (num<=69&&num>=60)
                {
                    average = 1;
                }


                else if (num<=60&&num>=0)
                {
                    average = 0;
                }

                
                return average;
            }

        }
    }
}
