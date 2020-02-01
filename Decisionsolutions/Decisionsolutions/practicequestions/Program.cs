using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicequestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1


            int number;
            number = 2;
            if (number > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
          

            //Question 2

            //int Age;

            //Console.WriteLine("Please enter your age:");
            //Console.ReadLine();
            //Age=




            //if (Age < 7 ) 
            //{
            //    Console.WriteLine($"your age of {Age} has an admission fee of: child 0.00");
            //}
            //if (Age > 7 && Age < 17)
            //{
            //    Console.WriteLine($"your age of {Age} has an admission fee of: students $9.80");

            //}
            //if (Age >18 && Age < 54)
            //{
            //    Console.WriteLine($"your age of {Age} has an admission fee of: Adult $11.35");

            //}
            //else
            //{
            //    Console.WriteLine($"your age of {Age} has an admission fee of: seniors $10.00");

            //}

            //Question 4
            //dollar amounts can be don with
            //a) formatting using 0.00 with or without $
            //b)a small c (currency) will have an automatic $
            //you can use the # sign as a digit placeholde in your format
            //the # sign is use"if digit space needed,use it"

            double Earnings = 65000 ;             //
            decimal taxAmount = 0.00m;           //if two words use camelCase
            const decimal FIVEPERCENT = 0.05m;
            const decimal SEVENPERCENT = 0.07m;
            const decimal NINEPERCENT = 0.09m; //CONST ALL CAPITAL LETTERS



            //using column aligned output
            //the syntax for formatting {variable,columnsize:formatstring}
            //variable is the data to output
            //columnsize is the no of character spacing to be used for
            //    the column
            //positive columnsize is right aligned
            //negative columnsize is left aligned
            //formatstring is your string format
            //put out the tax table as a column formatted table
            //using a \t character will give columns depending on the length of your output
            Console.WriteLine("Taxable income \t Tax Calculation");
            Console.WriteLine("up to $50,000  \t $0 + 5% OF up to 50,000");
            Console.WriteLine("up to $100000  \t $2500 + 7% OF AMOUNT OVER 50,000");
            Console.WriteLine("$100000 & over \t$6000 + 9% OF AMOUNT OVER 100,000");



            if (Earnings <= 50000)
            {
                //taxAmount is a decimal
                //Earnings is a double
                //the compliler does not like the mixture
                //solutions:a)make earnings a decimal
                //          b)make everything a double
                //          c)cast the earnings temporarily to a decimal ****
               taxAmount = (decimal)Earnings * FIVEPERCENT;

            }
            else
            {
                if (Earnings <= 100000)
                {
                    taxAmount = 2500.00m + (decimal)(Earnings - 50000) * SEVENPERCENT; //you can cast an entire expression

                }
                else
                {
                    taxAmount = 6000.00m + (decimal)(Earnings - 100000) * NINEPERCENT;

                }
                Console.WriteLine($"Earnings: {Earnings:$0.00}\t Taxes:{taxAmount:$0.00}");
                Console.WriteLine($"Earnings: {Earnings:c}\t Taxes:{taxAmount:c}");
                Console.WriteLine($"Earnings: {Earnings:$##,##0.00}\t Taxes:{taxAmount:$##,##0.00}");

                //output using column printing
                Console.WriteLine("{0,15} {1:13}", "Earnings:", "Taxes");
                Console.WriteLine($"{Earnings,15:$#,###.00} {taxAmount,13:$c}");
                Console.WriteLine("\n");

                Console.WriteLine("{0,15} {1:13}", "Earnings:", "Taxes");
                Console.WriteLine($"{Earnings,13:$#,###.00} {taxAmount,15:$c}");
                Console.WriteLine("\n");
            }
        }
    }
}
