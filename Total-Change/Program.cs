using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Change
{
    class Program
    {
        static void Print_Menu()
        {
            Console.WriteLine("This program computes depriciation tables using various methods of depriciation\n");
            Console.WriteLine("Please enter:" +
               "\n      A - to enter a new amount and/or Number of Years," +
               "\n      B - to use the straight-line method," +
               "\n      C - to use the sum-of-years-digits method," +
               "\n      D - to use the the double-declining balance method," +
               "\n      Q - to quit.\n");

        }
        static void  Amount_and_Years_input(double Amount , double Years)
        {
            bool validFlag = false;
            Console.WriteLine("How much money is to be depreciated? ");
            string inputString = Console.ReadLine();
            do
            {
                if (double.TryParse(inputString, out Amount) && Amount >= 0)
                {
                    validFlag = true;
                }
                else
                {
                    Console.WriteLine($"Invalid value ({inputString}). Try again or enter 0 to quit", inputString);
                }
            } while (validFlag == false);           //the amount and years both have to be  positive

            Console.WriteLine("Over how many years? ");
            inputString = Console.ReadLine();
            do
            {
                if (double.TryParse(inputString, out Years) && Years >= 0)
                {
                    validFlag = true;
                }
                else
                {
                    Console.WriteLine($"Invalid value ({inputString}). Try again or enter 0 to quit", inputString);
                }


            } while (validFlag == false);
            if (Amount == 0 || Years == 0)
            {
                Console.WriteLine("You have exited case A");
            }
        }
        static void  Straight_Line_Method(double Amount , double Years)
        {
            
            if (Amount > 0 && Years > 0)
            {
                Console.WriteLine("\t Year   Depriciation");
                Console.WriteLine("\t ------ --------------");
                for (double Year = 1;  Year <= Years; ++Year)
                {
                    double Depriciation = Amount / Years;
                    Console.WriteLine($"\t {Year:##} {Depriciation,15:C}");
                }
            }
            else
            {
                Console.WriteLine("Amount and Years must be greater than 0");
            }
        }
        static void Double_Declining_Method(double Amount, double Years)
        {
            if (Amount > 0 && Years > 0)
            {
                double sum = Years * (1 + Years) / 2;
                //use for loop to calcute for all the years
                Console.WriteLine("\t Year   Depriciation");
                Console.WriteLine("\t ------  --------------");
                for (double Year = 1; Year <= Years; ++Year)
                {
                    double Depriciation = (Years - Year + 1.0) * Amount / sum;
                    Console.WriteLine($"\t {Year:##} {Depriciation,15:C}");
                }//eol
            }
            else
            {
                Console.WriteLine("Amount and Years must be greater than 0");
            }
        }
        static void Sum_of_Years_Digits_Method(double Amount, double Years)
        {
            if (Amount > 0 && Years > 0)
            {
                double Ratio = 2 / Years;
                double RemainderAmount = Amount;
                Console.WriteLine("\t Year   Depriciation");
                Console.WriteLine("\t ---- --------------");
                for (double Year = 1; Year <= Years; ++Year)
                {
                    double Depriciation = RemainderAmount * Ratio;
                    Console.WriteLine($"\t {Year:##} {Depriciation,15:C}");
                    RemainderAmount -= Depriciation;
                    //subtraction assignment operator -= (Depriciation = Amount-RemainderAmount)
                    //Basically subtracting anumber by itself
                }
            }
            else
            {
                Console.WriteLine("Amount and Years must be greater than 0");
            }
        }
        static void UserOptions()
        {
            string Options="";
            double Amount=0;
            double Years=0;
            do
            {
                Print_Menu();
                Console.Write("Option?\t");
                Options = Console.ReadLine();

                switch (Options.ToUpper())
            {
                case "A":
                    {
                        Amount_and_Years_input(Amount, Years);
                        break;
                    }
                case "B":
                    {
                        Straight_Line_Method(Amount, Years);
                        break;
                    }
                case "C":
                    {
                        Sum_of_Years_Digits_Method(Amount, Years);
                        break;
                    }
                case "D":
                    {
                        Double_Declining_Method(Amount ,Years);
                        break;
                    }
                case "Q":
                    {

                        break;
                    }
               default:
                    {
                        Console.WriteLine($"***Invalid menu choice {Options}.");
                        break;
                    }
               
            }//end of switch
            } while (!Options.ToUpper().Equals("Q")); //end of do  while
        }//eostatic
    }
}
