using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest=0;
            //or
            int number;              // declare and default to 0
            const int Two = 2;
            string inputValue;

            Console.Write("Do you wish to play the even or odd game?");
            string answer = Console.ReadLine();

            

            //the loop strcture demonstr4ated in this sample is a pre test
            //pre test is alSO known as Do While
            //Pre test checks to see if the condition is true b4 executing the code
            //after the code has executed the pre test condition is still true
            //        if the condition is still true the loop code is reexecuted 
            //        if the condition is false the loop termninates and the xecution continues with the remaider of the program
            
            //the loop contructioon
            //(answer.ToUpper().Equals("Y")
            //answer=="Y" || answer=="y"
            while (answer.Equals("Y") || answer.Equals("y"))
            {
                ///within this coding block you are inside your loop
                /////this loop terminates if answer is not Yy
                /////ToDo. [lace your loop here
                System.Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);
                if ((number % Two) == 0)
                {
                    Console.WriteLine($"your number is even");
                }
                else
                {
                    Console.WriteLine($"your number {number} is odd");
                }
                //ask if the user wishes to continue to play the game
                //give user an opportunity to get out of the loop

                Console.Write("\n\nDo you wish to play the even or odd game?");
                 answer = Console.ReadLine();

            }//eow end of while
            //if you are outside of the while statement you are out of the loop
            Console.WriteLine("\n\nYou terminated the loop with your last answer");
            Console.ReadKey();

        }
    }
}
