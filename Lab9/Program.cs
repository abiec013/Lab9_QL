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
                Count++; //count gives the total circles tested

                Console.WriteLine("Welcome to the Circle tester!");
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine("Please enter radius");

                
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2)) 
                {
                    Console.WriteLine("Please enter a number");
                }

                newcircle.Radius = num2;
                    
                Console.WriteLine("This is the circumference " + newcircle.Circumferance());
                Console.WriteLine("This is the area " + newcircle.GetArea());

                bool choice = true;
                while (choice == true)
                {
                    Console.WriteLine("Continue? y/n"); //gives the user the option to continue or not
                    string userChoice = Console.ReadLine();
                    if (userChoice == "y" || userChoice == "Y")
                    {
                        Console.WriteLine("Good!");
                        choice = true;
                        break;
                        
                    }
                    else if (userChoice == "n" || userChoice == "N")
                    {

                        Console.WriteLine(" You have created " + "" + Count + " objects"  + " Bye Bye");
                        programContinues = false;
                        break;


                    }
                    else if (userChoice != "n" || userChoice != "N" || userChoice != "Y" || userChoice != "y")
                    {
                        Console.WriteLine("Please pick \"y\" or \"n\"");
                        choice = true;

                    }
                }
            }

        }
    }
}
