using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision001
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest=0;
              //or
            int first;              // declare and default to 0
            int second;             //declare and default to 0
            int highest = -99;      //declare and set to -99
            string message;         //declare and default to null
            string inputValue;

            System.Console.Write("Enter First number:\t");
            inputValue = Console.ReadLine();
            first = int.Parse(inputValue);
            
            //reuse, inputvalue because the previous contents
            //of inputValue has been stored elsewhere
            //variables hold one value at a time

            System.Console.Write("Enter second number:\t");
            inputValue = Console.ReadLine();
            second = int.Parse(inputValue);

            if(first > second)
            {
                //true path coding block
                //the condition on the if statemebnt is true
                highest = first;
                message = "first";   //literal string
                //literal can't change but message can
            }
            else
            {
                highest = second;
                message = "second";
                //false path coding block
                //the conditon on the if statement is false
            }//oef end of if know thats that's the end of the If statement
            Console.WriteLine($"first = {first}, second = {second}" +
                $",the {message} number entered had the higher value: {highest}");
            Console.ReadKey();  //can press any key
        }//eom end of method
    }//oec end of class
}//oes end of namespace
