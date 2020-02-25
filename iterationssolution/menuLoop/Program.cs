using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //generic munu setup
            //loop:post-loop
            //loop contents
            //prompt for menu option
            //switch with case for each option,
            //    default is bad menu option
            //    within the case output a message
            //decide how to terminate your loop

            string menuOption="";

            do
            {//prompts
                Console.WriteLine("select an option from the following menu");
                Console.WriteLine("A) fries");
                Console.WriteLine("B) chicken");
                Console.WriteLine("C) poutine");
                Console.WriteLine("D) smoothie");
                Console.WriteLine("X) Exit\n");
                Console.Write("Enter your menu option:\t");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                { 
                    case "A":
                    {
                            //place any logic to do in caseA
                        Console.WriteLine($"You entered the menu option of fries\n\n");
                        break;
                    }
                    case "B":
                    {
                        Console.WriteLine($"You entered the menu option of chicken\n\n");
                        break;
                    }
                     case "C":
                    {
                        Console.WriteLine($"You entered the menu option of poutine\n\n");
                        break;
                    }
                     case "D":
                    {
                        Console.WriteLine($"You entered the menu option of smoothie\n\n");
                        break;
                    }
                     case "X":
                    {
                        Console.WriteLine($"Thankyou! come again\n\n");
                        break;
                    }
                    default:
                        {
                        Console.WriteLine($"your menu option choice {menuOption} is incorrect.Try again");

                        break;
                    }



                }

            } while (menuOption.ToUpper() != "X");
            Console.ReadKey();
           
        }
    }
}
