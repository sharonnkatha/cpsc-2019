using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_inside_a_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuOption = "";

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
                                    //  inputString = Console.ReadLine();
                                    //while (int.TryParse(inputstring,out number))

                                    Console.Write("Enter a positive whole number or enter 0 to quit\n");
                                    inputSring = Console.ReadLine();
                                    //need a test to appropriately set your loop exit test
                                    if (int.TryParse(inputSring, out number))
                                    {
                                        //set the flag to an appropriate value to work with your logic
                                        validFlag = true;
                                    }
                                } while (validFlag == false);
                                //       
                                if (number > 0)
                                {
                                    if (number % 2 == 0) //% means if its divisible by 2
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
                            break;
                        }
                    case "B":
                        {
                            //plece the heads or tails game in this case
                            //validate then an h was entered ,if not repeat query for input


                            break;
                        }
                    case "C":
                        {
                           //the sum of squares
                           //enter +ve int number (validate)
                           //loop n times where n is the interger num (1 to n)
                           //within the loop your calculatin is total += loopnumber * loopnumber
                           //after the loop diplay your int no and its sum of squres
                           //ex enter 4
                           //loop 4 times 1) 1*1 2)2 * 2 3) 3*3 4) 4 * 4 final total =30
                            break;
                        }
                   



                }

            } while (menuOption.ToUpper() != "X");
            Console.ReadKey();
        }
    }
}
