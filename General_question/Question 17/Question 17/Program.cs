using System;

namespace Question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Your year and your anticipanted world population and numerical increase in the world !!!  ");

            int year = 0;

            int population = 700*2;

            double antici = 700;

            for (int i = 0; i <= 75; i++)
            {
                 double anticipant = antici + 100 * i;
                double numerical = (anticipant + 700) * i;

                Console.WriteLine($" {i} = Year         antipanted = {anticipant}              numerical increase = {numerical}   ");

                if (anticipant==population)
                {
                    year = i;
                }


               
            }

            Console.WriteLine($" \n The double year is {year}");
        }

    }
}
