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
            int number=1;
            string inputValue= "";
            string packageLetter;
            int numOfHours;
            double totalPayment = 0;

           
                do
                {
                    Console.WriteLine("Enter the service package A,B or C");
                    packageLetter = Console.ReadLine();

                Console.WriteLine("Please enter the number of hours");
                inputValue = Console.ReadLine();
                numOfHours = int.Parse(inputValue);

                switch (packageLetter.ToUpper())
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
                            totalPayment = 13.95 + (numOfHours - 20);
                            break;
                        }
                    case "C":
                        {
                            Console.WriteLine("19.95 for unlimited hrs");
                            totalPayment = 19.95;
                            break;
                        }

                }
                Console.WriteLine($"The amount due on your {packageLetter} plan is ${totalPayment}");
                } while (int.TryParse(inputValue, out number));


        }
    }
}
