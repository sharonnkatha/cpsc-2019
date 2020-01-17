using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();

            //is a singlee line comment
            /*is a block
              line
              comment
              group */
            //   c# is a "strongly typed" language
            //  character types:string(""); char('') 
            //  whole numerical types; integer and many others
            //  floating numerical types;decimal (28-29,double (15-16),float(7)
            //  logical type;boolean

            // declare variable withion main
            // general grammar (syntax) for declaring a variable is :
            // accesstype datatype variablename [=Value];
            //  special case:within a static class the accesstype is not required
            //by default numerical variables are set to 0
            decimal myWeight; //start witrh small letters 
            decimal myHeight;
            decimal BMI = 0.0m;
            //constant unchanging values are declared using the const syntax
            //you cannot change the value of a const variable
            const decimal ImperialBMIValue = 703.0m;


            //assign a value to a valuable
            //this statement is referred to as an assihgnment statement 
            //data moves from right to left on an assignment statement
            //on the left side of the equal sign will be the receiving storage area
            //on the righjt side of the equal sign will be trhe data you wish to store

            //numerical nuimbers need to ,match the variable datatype
            //integers have no decimal places
            //doubles are the default but may explicitly be type usind a d
            //decximals require to be explicitly typed using a m
            myWeight = 110.0m;
            myHeight = 1.75m;

            //math calculations follow the accepted rules of arithmetic
            // -assignment making a number negative
            // () execute within
            //*/ %
            //+-
            BMI = myWeight / (myHeight * myHeight);
            Console.WriteLine("According to your metric weight OF {0:0.0} and height OF {1:0.00} your BMI is {2:0.0}", myWeight, myHeight, BMI);

            //Imperial calculation
            myWeight = 242.5m;
            myHeight = 69.0m;
            BMI = (myWeight * ImperialBMIValue)(myHeight * myHeight);
            Console.WriteLine($"According to your metric weight OF {myWeight:0.0} and height OF {myHeight:0.00} your BMI is {2:0.0}");
        }
    }
}






        
    






