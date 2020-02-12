using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample of pretest loops
            //use the while loop
            //for loop

            //code a while loop that breaks the components 
            //      of a for loop into visible individual items
            //counter:this will count the number of time 
            //    through the loop
            //while condition: counter is less than my stop value
            //     (stop value is either an upper limit or lower limit)

            //go through the loop 7 times
            //count the number of even numbers, number of odd numbers
            //after the loop print out the even and odd number running totals
            int evenNumbers = 0;
            int oddNumbers = 0;
            string inputValue;
            int number;
            const int Two = 2;
            int loopCounter = 1;

            while (loopCounter <= 7)   //exactly 7 times
            {
                System.Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);
                if ((number % Two) == 0)
                {
                    //evennumbers = evennumbers +1
                    evenNumbers++;     //running total
                }
                else
                {
                    // oddnumbers = evennumbers +1
                    oddNumbers += 1;       //running total
                }//eof
                //increment the loop counter
                loopCounter++;


            }//eol end of loop
            Console.WriteLine($"your even  number count  is {evenNumbers}");
            Console.WriteLine($"your odd number count number is {oddNumbers}\n\n");


            //For loop
            //is a pre test loop structure
            evenNumbers = 0; //reset totals
            oddNumbers = 0;   //reset totals

            for(int forCounter = 1; forCounter <= 7; forCounter++ )   //if you add a ; the it only runs once
            {
                System.Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);
                if ((number % Two) == 0)
                {
                    //evennumbers = evennumbers +1
                    evenNumbers++;     //running total
                }
                else
                {
                    // oddnumbers = evennumbers +1
                    oddNumbers += 1;       //running total
                }//eof
                //increment the loop counter
                loopCounter++;
            }//eol
            Console.WriteLine($"your even  number count  is {evenNumbers}");
            Console.WriteLine($"your odd number count number is {oddNumbers}\n\n");

            //sentinal value - something to stop the loop
        }
    }
}
