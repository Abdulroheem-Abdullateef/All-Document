using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int headcount = 0;
            int tailcount = 0;


            while (true)
            {
                if (Flip()==false)
                {
                    tailcount++;
                }

                else if (Flip()==true)
                {
                    headcount++;
                }

                Console.WriteLine("To end this game type 'stop' ");
                string answer = Console.ReadLine();
                if (answer=="stop")
                {
                    break;
                }
            }

            Console.WriteLine($"the  tail is {tailcount} and head is  {headcount}  ");


            static  bool Flip()
            {
                 
                Console.WriteLine("Tossing of coin between 0 and 1");
                
                
                bool flip = true;
                
                        Random rmd = new Random();
                        int random = rmd.Next(0, 2);
                    

                        if (random==0)
                        {
                            flip = true;     
                        }
                        

                        
                        else if (random==1)
                        {
                            flip = false;
                        }

                        return flip;






            }
        
                    
                        

                    
        }
    }
}
