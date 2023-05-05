using System;

namespace brotoheebquestion2
{
    class Program
    {
        
        static void Main(string[] args)
        {



            string firstname = "Ade";

            string lastname = "Bayo";

            string final = "Bayo";


            


            string replace = firstname.Substring(0,1);

            Console.WriteLine(replace);


            string changename = firstname.Insert(0 ,"seun");

            Console.WriteLine(changename);            

            
            bool a = lastname.Equals(final);


            Console.WriteLine(a);


            //string boy = "The boy's ball he said \" he is good\"";

            //Console.WriteLine(boy);



       




        }
    }
}
