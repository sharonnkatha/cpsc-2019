using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalconditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical conditions are two or more conditions
            //separated by a logic expression
            //relative operator
            //> >= < <= == !=
            //operan operator operan
            //high>low
            //logica operators
            //|| (or) && (and) ! (not) 

            int Age = 6;
            if (Age< 4)
            {
                Console.WriteLine("Too young");
                
            }
            else if (Age > 14)
            {
                Console.WriteLine("Too old");

            }
            else
            {
                Console.WriteLine("Welcome to the league");

            }
            //but what about using logical operators
            //note operand is repeated for each relative test condition
            //(Age < 4 || Age >14) is correct syntax

            //Truth table
            //condition     or        and
            // T T          T           T
            // T F          T           F
            // F T          T           F
            // F F          F           F

            //SUMMARY && only true if Both conditions are true
            //        || only false if Both conditions are false

            if (Age < 4 || Age > 14)
            {
                //one does not know if they are too old or too young
                Console.WriteLine("Sorry you are not in the age bracket for the league");
               
            }
            else
            {
                Console.WriteLine("Welcome to the league");
            }
        }
    }
}
