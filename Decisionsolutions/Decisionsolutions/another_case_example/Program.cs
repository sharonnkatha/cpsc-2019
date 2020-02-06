using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace another_case_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out the month name
            int monthNumber = 5;     //argument 
            ///there is a single aregument variable
                //this single argument variable will be tested against multipke constatnt values
                //the case test is an == test
                //has to be an equal test
            
            switch(monthNumber)
            {
                case 1:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is january.");
                        break;
                    }
                case 2:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is february.");
                        break;
                    }
                case 3:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is march.");
                        break;
                    }
                case 4:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is april.");
                        break;
                    }
                case 5:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is may.");
                        break;
                    }
                case 6:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is june.");
                        break;
                    }
                case 7:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is july.");
                        break;
                    }
                case 8:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is august.");
                        break;
                    }
                case 9:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is september.");
                        break;
                    }
                case 10:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is october.");
                        break;
                    }
                case 11:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is november.");
                        break;
                    }
                case 12:
                    {
                        //do any logic that is requireds when month number is 1
                        //could be 1 line or 10000 lines of code
                        Console.WriteLine($"the name of the month is december.");
                        break;
                    }
                default:
                    {
                        //done if one oif the previous cases wasn't executed
                        Console.WriteLine("invalid number entry");
                        break;
                    }
            }

        }
    }
}
