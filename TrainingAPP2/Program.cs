using System;

namespace TrainingAPP2
{
    class Program
    {
        static void Main(string[] args)
        {//Code block of Main method

            Console.WriteLine("Hello World!");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello" + userName);
            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge > 17)
            {
                Console.WriteLine("Do you want a Beer?");
            }



        }//End of Main method
    }


  

