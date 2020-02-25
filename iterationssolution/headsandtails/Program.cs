using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace headsandtails
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string menuOption = "";

            do
            {
                //prompts
                Console.WriteLine("Select a option from the following menu:");
                Console.WriteLine("A) Play Even or Odds");
                Console.WriteLine("B) Do case B heads bor tails game");
                Console.WriteLine("C) Do case C");
                Console.WriteLine("X) Exit\n");
                Console.Write("Entry your menu option:\t");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {
                    case "A":
                        {
                            Even_Or_Odds();
                            
                            break; //the break is part of the case not the method
                        }
                    case "B":
                        {
                            //create a method that holds the actual code for this case
                            //the B case will call the nmethod to execute
                            //thius action is refereed to as the calling statement
                            //calling the method brequires your code to use the method name
                            //your program will beanch to the requested method
                            //when the method has finished the program will return to the next executable statement
                            //     after rhe method call

                            Heads_Or_Tails_Game();

                            break;
                        }
                    case "C":
                        {
                            //the sum of squares
                            //enter postive integer number (validate)
                            //loop n times where n is the integer number (1 to n)
                            //within the loop your calculation is  total += loopnumber * loopnumber
                            //after the loop display your integer number and its sum of squares
                            // entered 4
                            //loop 4 times  1) 1* 1 2) 2* 2 3) 3 * 3 4) 4 * 4 final total = 30
                            Console.WriteLine($"You entered the menu option  of C.\n\n");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine($"Thank you. Come again\n\n");
                            break;
                        }
                    default:
                        {
                            //this case acts as a validation for the proper value of a menuOption
                            Console.WriteLine($"Your menu option choice of {menuOption} is incorrect. Try again.\n\n");
                            break;
                        }
                }
            } while (menuOption.ToUpper() != "X");
            Console.ReadKey();
        }//end of main)
         //the syntax for method requires
         //accesstype returndatatype methodeNme ([list of parameters])
         //{
         //   your method code
         //}eom

        //accesstype:piblic or private
        //         protected , internal, have static NullReferenceException
        //returndatatype: if you are returning notyhing use a key work void
        //                otherwise,return a single value such as int,double,decimal etc
        //methodname: :continous string of characters which will be used within 
        //                    your program code to reference this coding block
        //               always use a meaningful name
        //[list of parameters] this is a set of localvariwbles theat will be used to receive bvalues from the
        //                     calling statement
        //                      a parameter is a set of datatype and varieble name
        //                      parameters are separated by using a comma,
        //
        static public void Heads_Or_Tails_Game()
        {
            int headcount= 0;
            int tailcount= 0;
            Console.WriteLine("\n\n I reached my method for option B");
            string inputstring= "";
            do
            {
                //validation
                do
                {
                    Console.WriteLine("enter a H for (heads or T for tails or Q to quit");
                    inputstring = Console.ReadLine();
                } while (!inputstring.ToUpper().Equals("H")&&
                          !inputstring.ToUpper().Equals("T")&&
                         !inputstring.ToUpper().Equals("Q"));
                if (!inputstring.ToUpper().Equals("H") ||
                     !inputstring.ToUpper().Equals("T"))
                {
                    //heads ot tails
                    if(!inputstring.ToUpper().Equals("H"))
                    {
                        headcount++;
                        Console.WriteLine($"\n\n{inputstring.ToUpper()} is heads");
                    }
                    else
                    {
                        tailcount++;
                        Console.WriteLine($"\n\n{inputstring.ToUpper()} is tails");

                    }
                }
                else
                {
                    if (headcount > tailcount)
                    {
                        Console.WriteLine($"Heads wins over tails: { headcount} to {tailcount}");
                    }
                    else if(tailcount > headcount)
                    {
                        Console.WriteLine($"tails wins over heads: { tailcount} to {headcount}");
                    }
                    else
                    {
                        Console.WriteLine($"Heads ties tails: { headcount} to {tailcount}");
                    }
                    //quit
                    Console.WriteLine("\n\n Thankyou.Hope you enjoy the game");
                }

            } while (!inputstring.ToUpper().Equals("Q"));
        }//eom Heads_Or_Tails_Game
        static public void Even_Or_Odds()
        {int number = -1;
                            string inputString = "";

                            while (number != 0)
                            {
                                //do
                                //{
                                //    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                                //    inputString = Console.ReadLine();
                                //} while (!int.TryParse(inputString, out number));

                                //condition flag
                                //NOTE: it MUST be reset on EACH pass of the OUTER loop
                                bool validFlag = false;
                                do
                                {
                                    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                                    inputString = Console.ReadLine();
                                    //need a test to appropriately set your loop exit test
                                    if (int.TryParse(inputString, out number))
                                    {
                                        //set the flag to an appropriate value to work with your logic
                                        validFlag = true;
                                    }
                                } while (validFlag == false);

                                if (number > 0)
                                {
                                    if (number % 2 == 0)
                                    {
                                        Console.WriteLine($"{number} is an even value.\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{number} is an odd value.\n\n");
                                    }
                                }
                                else
                                {
                                    if (number == 0)
                                    {
                                        Console.WriteLine($"thank you. come again.\n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{number} is invalid. try again.\n\n");
                                    }
                                }
                            }//eol while


        }//eom Even_Or_Odds()
    }
       
}

