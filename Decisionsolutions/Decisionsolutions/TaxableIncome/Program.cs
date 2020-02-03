using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxableIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            double Income;
            decimal taxAmount;
            const decimal  FIVEPERCENT= 0.05m;
            const decimal SEVENPERCENT = 0.07m;
            const decimal NINEPERCENT = 0.09m;
            string inputValue;
            
            Console.WriteLine($"Please enter your annual income");
            inputValue = Console.ReadLine();
            Income = double.Parse(inputValue);
            
            if (Income <= 50000)
                {
                taxAmount = (decimal)Income * FIVEPERCENT;
            }
            else
            {
                if (Income >= 100000)
                    {
                    taxAmount = 2500.00m + SEVENPERCENT * (decimal)(Income -50000);
                }
                else
                {
                    taxAmount = 6000.00m + NINEPERCENT * (decimal)(Income - 100000);
                }
            }
            Console.WriteLine($"The Income tax due on yout taxable income of \t ${Income} is \t ${taxAmount}" );


        }
    }
}
