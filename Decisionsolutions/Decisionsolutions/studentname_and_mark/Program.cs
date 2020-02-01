using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentname_and_mark
{
    class Program
    {
        static void Main(string[] args)
        {
            string Grade;
            double StudentMark;
            string InputValue;
            string StudentName;

            Console.WriteLine("Please enter your name ");
            InputValue = Console.ReadLine();
            StudentName = InputValue;

            Console.WriteLine("Please enter your Mark ");
            InputValue = Console.ReadLine();
            StudentMark = double.Parse(InputValue);
            //  question 2 
            Console.WriteLine($"Quetion 1\n");
            int numArg= -1;
            if (numArg == 0)
            {
                Console.WriteLine($"The  number {numArg} is zero");
            }
            else
            {
                Console.WriteLine($"The number {numArg} is negative");
            }
            Console.WriteLine("\n\n");    

            //question3

        }
    }
}
