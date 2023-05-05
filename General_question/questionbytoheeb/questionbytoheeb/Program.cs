using System;

namespace questionbytoheeb
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter you number");
            //int number = int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter you number");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter you number");
            //int number3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter you number");
            //int number4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter you number");
            //int number5 = int.Parse(Console.ReadLine());

            //if (number<number2&&number2<number3&&number3<number4&&number4<number5)
            //{
            //    Console.Write($"{number},{number2},{number3},{number4},{number5}");
            //}

            //else 
            //{
            //    Console.WriteLine("false");
            //}



            bool isacending = true;
            int previous = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter you number");
                int number = int.Parse(Console.ReadLine());

                if (i<=0)
                {
                    previous++;
                    
                }
                else if (number<0)
                {
                    isacending = false;
                }

                        
            }






        }


    }
}
