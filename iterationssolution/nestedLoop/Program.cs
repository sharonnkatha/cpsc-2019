using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //query user for a number 
            //validate a number was entered (integer)
            //if a number was entered check for even/odd
            //continue unless a 0 was entered then exit
            //to validate a stringf to contain a number use thye xxxx.TryParse of the number data type
            //syntaxx of .TryParse has a (string, out variablename)
            //string holds value to test
            //if valu is good:
            //   the no is automatically place in your variable]
            //   the test returns a boolean true
            //if the value is not good :
            //No vqalue is placed in your variable 
            //   the test retursn a boolean false

            //condition flag
            //note:it must be reset on eacg pass of the outer l;oop

            int number = -1;
            string inputSring = "";

            while (number != 0)
            {
                bool validFlag = false;
                do
                {
                    // do
                    //
                    //   Console.Write("Enter a positive whole number or enter 0 to quit\n");
                    //  inputSring = Console.ReadLine();
                    //while (int.TryParse(inputstring,out number))

                     Console.Write("Enter a positive whole number or enter 0 to quit\n");
                    inputSring = Console.ReadLine();
                    //need a test to appropriately set your loop exit test
                    if(int.TryParse(inputSring , out number))
                    {
                        //set the flag to an appropriate value to work with your logic
                        validFlag = true;
                    }
                } while (validFlag == false); 
                //       
                if (number > 0)
                {
                    if (number % 2 ==0) //% means if its divisible by 2
                    {
                        Console.WriteLine($"{number} is an even value.\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is an even value.\n");
                    }
                }
                else
                {
                    if (number == 0)
                    {
                        Console.WriteLine($"Thankyou come again.\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is invalid.Try again.\n");
                    }
                }

            }
           

        }
    }
}
