using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your distance X1");
            double x1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter your distance X2");
            double x2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter your distance Y1");
            double y1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter your distance Y2");
            double y2 = double.Parse(Console.ReadLine());


            Console.WriteLine(Point(x1,x2,y1,y2));





            static double Point(double a, double b,double c,double d)
            {
                
                
                
                double circle = Math.Sqrt(a);
               
                double circle2 = Math.Sqrt(b);
                
                double circle3 = Math.Sqrt(c);

                double circle4  = Math.Sqrt(d);

                double side =  Math.Sqrt((circle2 - circle) + (circle4 - circle3));

                return side;


            }

        }
    }
}
