 using System;

namespace Question_on_swich
{
    class Program
    {
        static void Main(string[] args)
        {
            double maximum = 100;

   
            Console.WriteLine("Enter your Mathematics");
            double math = double.Parse(Console.ReadLine());
            double mathgrade = (math / maximum) * 100;


            if (mathgrade >= 90 && mathgrade <= 100)
            {
                Console.WriteLine(" Your math grade is (A)");
            }


            else if (mathgrade >= 70 && mathgrade <= 89)
            {
                Console.WriteLine(" Your math grade is (B) ");
            }


            else if (mathgrade >= 60 && mathgrade <= 79)
            {
                Console.WriteLine(" Your math grade is (C) ");
            }


            else if (mathgrade >= 50 && mathgrade <= 69)
            {
                Console.WriteLine(" Your math grade is (D)");
            }


            else if (mathgrade >= 40 && mathgrade <= 59)
            {
                Console.WriteLine(" Your math grade is (E)");
            }


            else if (mathgrade >= 30 && mathgrade <= 49)
            {
                Console.WriteLine(" Your math grade is (F) ");
            }




            Console.WriteLine("Enter your English");
            double english = double.Parse(Console.ReadLine());
            double enggrade = english / maximum * 100;

            if (enggrade >= 90 && enggrade <= 100)
            {
                Console.WriteLine(" Your english grade is (A) ");
            }


            else if (enggrade >= 70 && enggrade <= 80)
            {
                Console.WriteLine(" Your english grade is (B) ");
            }


            else if (enggrade >= 60 && enggrade <= 79)
            {
                Console.WriteLine(" Your english grade is (C) ");
            }


            else if (enggrade >= 50 && enggrade <= 69)
            {
                Console.WriteLine("Your english grade is (D) ");
            }


            else if (enggrade >= 40 && enggrade <= 59)
            {
                Console.WriteLine(" Your english grade is (E) ");
            }


            else if (enggrade >= 30 && enggrade <= 49)
            {
                Console.WriteLine("Your english grade is (F) ");
            }




            Console.WriteLine("Enter your Physic");
            double physic = double.Parse(Console.ReadLine());
            double phygrade = physic / maximum * 100;

            if (phygrade >= 90 && phygrade <= 100)
            {
                Console.WriteLine("Your phy grade is (A) ");
            }


            else if (phygrade >= 70 && phygrade <= 80)
            {
                Console.WriteLine("Your phy grade is (B)");
            }


            else if (phygrade >= 60 && phygrade <= 79)
            {
                Console.WriteLine("Your phy grade is (C)");
            }


            else if (phygrade >= 50 && phygrade <= 69)
            {
                Console.WriteLine("your phy grade (D) ");
            }


            else if (phygrade >= 40 && phygrade <= 59)
            {
                Console.WriteLine(" Your physic grade is (E)");
            }


            else if (phygrade >= 30 && phygrade <= 49)
            {
                Console.WriteLine(" your physic grade is (F) ");
            }



            Console.WriteLine("Enter your chem");
            double chemistry = double.Parse(Console.ReadLine());
            double chemgrade = chemistry / maximum * 100;

            if (chemgrade >= 90 && chemgrade <= 100)
            {
                Console.WriteLine("Your chemistry grade is (A) ");
            }


            else if (chemgrade >= 70 && chemgrade <= 80)
            {
                Console.WriteLine("Your chemistry grade is (B) ");
            }


            else if (chemgrade >= 60 && chemgrade <= 79)
            {
                Console.WriteLine("Your chemistry grade is (C) ");
            }


            else if (chemgrade >= 50 && chemgrade <= 69)
            {
                Console.WriteLine("Your chemistry grade is (D)");
            }


            else if (chemgrade >= 40 && chemgrade <= 59)
            {
                Console.WriteLine("Your chemistry grade is (E)");
            }


            else if (chemgrade >= 30 && chemgrade <= 49)
            {
                Console.WriteLine("Your chemistry grade is (F)");
            }




            Console.WriteLine("Enter your Biology");
            double bio = double.Parse(Console.ReadLine());
            double biograde = bio / maximum * 100;

            if (biograde >= 90 && biograde <= 100)
            {
                Console.WriteLine("Your bio grade is (A)");
            }


            else if (biograde >= 80 && biograde <= 70)
            {
                Console.WriteLine("Your bio grade is (B)");
            }


            else if (biograde >= 79 && mathgrade <= 60)
            {
                Console.WriteLine("Your bio grade is (C)");
            }


            else if (biograde >= 69 && biograde <= 50)
            {
                Console.WriteLine("Your bio grade is (D)");
            }

               
            else if (biograde >= 59 && biograde <= 40)
            {
                Console.WriteLine("Your bio grade is (E)");
            }


            else if (biograde >= 49 && biograde <= 30)
            {
                Console.WriteLine("Your bio grade is (F) ");
            }







            //Console.WriteLine("Enter your future day");  
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{

            //    case 1:
            //        Console.WriteLine("Today is sunday");
            //        break;

            //    case 2:

            //        Console.WriteLine("Today is Monday");
            //        break;

            //    case 3:
            //        Console.WriteLine("Today is Tuesday");
            //        break;

            //    case 4:

            //        Console.WriteLine("Today is Wednesday");
            //        if (DateTime.Now.Hour > 16)
            //        {
            //            Console.WriteLine("In Islam day, we have move to another day");

            //        }
            //        break;

            //    case 5:
            //        Console.WriteLine("Today is Thursday");
            //        break;

            //    case 6:
            //        Console.WriteLine("Today is Friday");
            //        break;

            //    case 7:
            //        Console.WriteLine("Today is Saturday");
            //        break;

            //    default:
            //        Console.WriteLine("Today is sunday");
            //        break;
            //}


            //int num1 = int.Parse(Console.ReadLine());

            //var result1 = (num1 % 2 == 0) ? "Odd number" : "Even number";

            //Console.WriteLine(result1);



        }
    }
}
