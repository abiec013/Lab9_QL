using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            bool programContinues = true;
            while (programContinues == true)
            {

               
                Circle newcircle = new Circle();
                Count++;

                Console.WriteLine("Welcome to the Circle test!");
                Console.WriteLine("Enter radius");
                newcircle.radius = double.Parse(Console.ReadLine());

                if (newcircle.radius < 0)
                {

                }
                    
                Console.WriteLine("This is the circumference " + newcircle.Circumferance());
                Console.WriteLine("This is the area " + newcircle.GetArea());

                Console.WriteLine("Continue? y/n");
                string userChoice = Console.ReadLine();
                if (userChoice == "y")
                {
                    programContinues = true;
                }
                else
                {
                   
                    
                    programContinues = false;
                    Console.WriteLine("Bye Bye" + " you have created " + " " + Count + " objects");


                }

            }

        }
    }
}
