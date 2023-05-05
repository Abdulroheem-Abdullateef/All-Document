using System;

namespace Question_18
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;


            Console.WriteLine("possible anwser to the question by using capital Letter A to D :");
            Console.WriteLine("your question is ............. A - D ");



            Console.WriteLine("Welcome to Global warming Question");

            Console.WriteLine("Question 1");
            Console.WriteLine("What is Global Warming ?");

            Console.WriteLine("  ");

            Console.WriteLine(" A = Is the heat trapping greenhouse gas level ");
            Console.WriteLine(" B = is the long term heating of earth's climate system  ");
            Console.WriteLine(" C = is the primarily fossil fuel burning ");
            Console.WriteLine(" D = is the increasing levels of carbon  ");

            string userinput = Console.ReadLine();

            Console.WriteLine("  ");
            
            string ans1 = "A";
            string ans2 = "B";
            string ans3 = "C";
            string ans4 = "D";

            Console.WriteLine("  ");

            if (userinput != ans1 && userinput == ans2 && userinput != ans3 && userinput != ans4)
            {
                Console.WriteLine("Correct ");
                
                count++;
            }


            
            else
            {
                Console.WriteLine("Invalid answer; the correct answer is  (B)  ");
                Console.WriteLine(" is the long term heating of earth's  climate system");
            }




            Console.WriteLine("Question 2");
            Console.WriteLine("What ranks of global warming is ?");

            Console.WriteLine("  ");
            Console.WriteLine(" A = is 0.18 degree celcius ");
            Console.WriteLine(" B = is 0.13 degree fahrenheit ");
            Console.WriteLine(" C = Is Average rate of 0.13 degrees fahrenheit ");
            Console.WriteLine(" D = is 0.08 degrees celsius  ");

            string ranks = Console.ReadLine();
            Console.WriteLine("  ");

            string Q1 = "A";
            string Q2 = "B";
            string Q3 = "C";
            string Q4 = "D";

            if (ranks != Q1 && ranks != Q2 && ranks == Q3 && ranks != Q4)
            {
                Console.WriteLine("Correct ");
                count++;

            }

            else
            {
                Console.WriteLine("Invalid answer; the correct answer is  (C)  ");
                Console.WriteLine("Is Average rate of 0.13 gegrees fahrenheit ");
            }





            Console.WriteLine("Question 3");
            Console.WriteLine("What is climate change ?");

            string QC1 = "A";
            string QC2 = "B";
            string QC3 = "C";
            string QC4 = "D";

            Console.WriteLine("  ");

            Console.WriteLine("  A = Climate change cause greenhouse  ");
            Console.WriteLine("  B = is the main cause of climate change ");
            Console.WriteLine("  C = is the fossil fuels and convert land from forests to agriculture ");
            Console.WriteLine("  D =  A  and D ");

            string climate = Console.ReadLine();

            Console.WriteLine("  ");

            if (climate != QC1 && climate != QC2 && climate != QC3 && climate == QC4)
            {
                Console.WriteLine("Correct ");
                count++;

            }

            else
            {
                Console.WriteLine("Invalid answer; the correct answer is  (D)  ");
                Console.WriteLine("Climate change cause greenhouse of fossil fuel and convert land from forest to agriculture ");
            }





            Console.WriteLine("Question 4 ");
            Console.WriteLine("What is climate change impact ?");



            string QI1 = "A";
            string QI2 = "B";
            string QI3 = "C";
            string QI4 = "D";

            Console.WriteLine("  ");

            Console.WriteLine(" A =  Increase Heat ");
            Console.WriteLine(" B = Drought ");
            Console.WriteLine(" C =  All above ");
            Console.WriteLine(" D =  Insect outbreaks ");

            string impact = Console.ReadLine();

            Console.WriteLine("  ");

            if (impact != QI1 && impact != QI2 && impact == QI3 && impact != QI4)
            {
                Console.WriteLine("Correct ");
                count++;
            }

            else
            {
                Console.WriteLine("Invalid answer; the correct answer is  (C)  ");
                Console.WriteLine("ALL above ");
            }




            Console.WriteLine("Question 5 ");
            Console.WriteLine("What does global warnming have to do with several weatherlike stoma, heat waves, drought and hurricanes ?");

            Console.WriteLine("  ");

            string Qw1 = "A";
            string Qw2 = "B";
            string Qw3 = "C";
            string Qw4 = "D";


            Console.WriteLine(" A = Rising Maximum temperature ");
            Console.WriteLine(" B = Rising sea level  ");
            Console.WriteLine(" C = Rising Minimum temperature  ");
            Console.WriteLine(" D = All of the above  ");


            Console.WriteLine("  ");


            string warnming = Console.ReadLine();
            if (warnming != Qw1 && warnming != Qw2 && warnming == Qw3 && warnming != Qw4)
            {
                Console.WriteLine("Correct ");
                count++;
            }

            else
            {
                Console.WriteLine("Invalid answer; the correct answer is = (C)  ");
                Console.WriteLine("ALL of the above ");
            }

            if (count == 5)
            {
                Console.WriteLine("Excellent");
            }
            else if (count == 4)
            {
                Console.WriteLine("Very Good");
            }
            else if (count == 3 || count < 4)
            {
                Console.WriteLine("Time To Brush up on Your Knowledge of global warming,");
            }

            else
            {
                Console.WriteLine(" Visit our websites where you found your climate (www.google.com)");
            }

        }
    }
}
