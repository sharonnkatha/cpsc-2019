using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inout
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *implement a temperature converter from celcius to fahrenheit
             * 
             * January 15 2020
             */

            //input : celcius temperature 
            //         string input temp
            //         double theCelciusTemperature

            //output:fahrenheit temperature
            //         double thefahrenheitTemperature

            //expression:(ct* 9/5) +32 = ft
            //check with ct =0 expect ft=32
            //check with ct=-40 expect ft=-40
            //check with cxt=100 expect ft=212

            //prompt for a temperature
            //.write keeps ypur cursor on the same line
            Console.Write("enter a celcius temperature:\t");

            //to obtain the key strokes that the user types 9input0
            //use .Readline()
            //data comes into the program as a sting

            string inputTemp = Console.ReadLine();

            //convert rthe string to a double 
            //to do this you will use parsing
            //    syntax:    datatypeTo.Parse9string)
            double. theCelciusTemperature = double.Parse(inputTemp);

            //calculartion using the conversion expression
            double thefahrenheitTemperature = (theCelciusTemperature * (9.0 / 5.0)) + 32.0;
            //output
            //.Writeline automatically goes to the next line
            Console.WriteLine($"The celcius temperature of {theCelciusTemperature}in " + $ farenheit is { thefahrenheitTemperature }");

                //to ensure that your display stays whether you run without debugging (ctrl+f5)
                //or running with debugging (f5 or the start button at the top)
                //add 

            Console.ReadLine();
        }
    }

}
