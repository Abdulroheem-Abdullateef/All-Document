using System;

namespace Question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of integer one");
            int integer1=int.Parse(Console.ReadLine());


            Console.WriteLine("Enter number of integer two");
            int integer2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter number of integer three");
            int integer3 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter number of integer four");
            int integer4 = int.Parse(Console.ReadLine());


            
            
            int addition1= integer1 + 7 ;

            int addition2 = integer2 + 7 ;

            int addition3 = integer3 + 7 ;

            int addition4 = integer4 + 7 ;




            int add1 = addition1 / 10;

            int add2 = addition2 / 10;

            int add3 = addition3 / 10;

            int add4 = addition4 / 10;

            
                
                
            int modulo1 = addition1 % 10;

            int modulo2 = addition2 % 10;

            int modulo3 = addition3 % 10;

            int modulo4 = addition4 % 10;



            modulo1 = modulo1 + modulo3;
            modulo3 = modulo1 - modulo3;
            modulo1 = modulo1 - modulo3;

            Console.WriteLine($" The encrypted integer is {modulo1} , {modulo2} , {modulo3} , {modulo4} ");


            modulo2 = modulo2 + modulo4;
            modulo4 = modulo2 - modulo4;
            modulo2 = modulo2 - modulo4;

            Console.WriteLine($" The encryted integer is {modulo1},{modulo2},{modulo3},{modulo4}");







            modulo1 = modulo1 + modulo3;
            modulo3 = modulo1 - modulo3;
            modulo1 = modulo1 - modulo3;


            modulo2 = modulo2 + modulo4;
            modulo4 = modulo2 - modulo4;
            modulo2 = modulo2 - modulo4;








            int result1 = add1 * 10;

            int result2 = add2 * 10;

            int result3 = add3 * 10;

            int result4 = add4 * 10;


            int final1 = result1 + modulo1;

            int final2 = result2 + modulo2;

            int final3 = result3 + modulo3;

            int final4 = result4 + modulo4;


            int outcome1 = final1 - 7;

            int outcome2 = final2 - 7;

            int outcome3 = final3 - 7;

            int outcome4 = final4 - 7;

            Console.WriteLine($" The encyption scheme is {outcome1} , {outcome2} , {outcome3} , {outcome4} ");









        }
    }
}
