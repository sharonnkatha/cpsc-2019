using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*program to calculate how much to bill customers
             *A. 9.95 per month upto 10hrs additional hrs $2.00 per hr
             *B.13.95 "          "   20hrs                $1.00
             *C. 19.95           for unlimited hrs
             * add for loop
             *
             */
            string packageLetter;
            int numOfHours;
            string inputValue;
            double totalPayment=0;
            int loopCounter;
            
            Console.WriteLine("Enter the service package A,B or C");
            packageLetter = Console.ReadLine();
             

            Console.WriteLine("Please enter the number of hours");
            inputValue = Console.ReadLine();
            numOfHours = int.Parse(inputValue);

            switch(packageLetter.ToUpper())
            {
                case "A":
                    {
                        Console.WriteLine("The plan is 9.95 per month upto 10hrs additional hrs = $2.00 per hr");
                        totalPayment = 9.95 + ((numOfHours - 10) * 2);
                        break;
                    }
                case "B":
                    {
                        Console.WriteLine("13.95 per month upto 20hrs additional hrs= $1.00 per hr");
                        totalPayment = 13.95 + (numOfHours - 20) ;
                        break;
                    }
                case "C":
                    {
                        Console.WriteLine("19.95 for unlimited hrs");
                        totalPayment = 19.95;
                        break;
                    }
                    
            }
            Console.WriteLine($"The amount due on your {packageLetter} plan is ${totalPayment}" );


        }
    }
}
