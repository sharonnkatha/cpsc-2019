using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations_PostTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;              // declare and default to 0
            const int Two = 2;
            string inputValue;
            string answer;



            //the loop strcture demonstr4ated in thiks sample is a post test
            //post test is alos known as Do ntil
            //post test executes the code once before the loop condition is tested
            //after the code has executed the post test condition is still for true
            //if the condition is still true the loop code is reexecuted 
            //if the condition is false the loop termninates and the xecution 
            //     continues with the remaider of the program

            //the loop contructioon
            //(answer.ToUpper().Equals("Y")
            //answer=="Y" || answer=="y"

            ///within this coding block you are inside your loop
            /////this loop terminates if answer is not Yy
            /////ToDo. [lace your loop here
            ///
            do
            {
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

                Console.Write("\n\nDo you wish to continue playing the even or odd game?");
                answer = Console.ReadLine();

            } while (answer.ToUpper().Equals("Y"));


                
           
            //if you are outside of the while statement you are out of the loop
            Console.WriteLine("\n\nYou terminated the loop with your last answer");
            Console.ReadKey();
            //pre test starts with a while
            //post test starts with a do and ends with while
            //you dont have to ask twice like pre test
        }
    }
}
