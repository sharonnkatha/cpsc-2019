using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest=0;
            //or
            int number;              // declare and default to 0
            const int Two = 2;
            string inputValue;


           
            
            
            System.Console.Write("Enter a number:\t");
            inputValue = Console.ReadLine();
            number = int.Parse(inputValue);

           

            
            if ((number % Two)==0)
            {
                //true path coding block
                //the condition on the if statemebnt is true
                Console.WriteLine($"your number is even");
            }
            else
            {
                highest = second;
                message = "second";
                //false path coding block
                //the conditon on the if statement is false
                Console.WriteLine($"your number is odd");
            }
            
            Console.ReadKey();  //can press any key
        }
    }
}
