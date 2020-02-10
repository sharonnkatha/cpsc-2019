using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitconversionsprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 2
            /*
             * program for simple unit conversions
             * display menu of availabel options
             * prompt for desired option 
             * prompt for a value
             * conversion should be performed and the new value should be applied
             * us e thye table 
             * 
             * allow for conversions in the opposite direction
             * eg kg to pounds and vice versa
             * ikg = 2.2
             * CONVERSION FORMULA
                POUNDS TO KILOGRAMS             kg = lb / 2.2046
                FLUID OUNCES (U.S.) TO LITERS   1 liter = 33.8140226 ounces
               INCHES TO CENTIMETERS            cm = in / 0.39370
                 FAHRENHEIT TO CELSIUS          C = (F - 32) / 1.800
             */
            
            string conversionOption="";
            double Value;
            double Total = 0;

            //menu of available options
            Console.WriteLine("Unit of Conversions Program");
            Console.WriteLine("Choose between these options");
            Console.WriteLine("1a.Pounds to kilograms");
            Console.WriteLine("1b.kilograms to pounds");
            Console.WriteLine("2a.fluid ounces to litres");
            Console.WriteLine("2b.litres to ounces");
            Console.WriteLine("3a.inches to centimeters");
            Console.WriteLine("3b.centimetres to inches");
            Console.WriteLine("4a.fahrenheit to celcius");
            Console.WriteLine("4b.celcius to farenheit\n");

            Console.WriteLine("Enter the desired unit of conversion ");
            string inputValue=Console.ReadLine();
            conversionOption = inputValue;
            Console.WriteLine("\n");

            Console.WriteLine("Enter the value of unit");
            inputValue = Console.ReadLine();
            Value = double.Parse(inputValue);


            
            switch (conversionOption.ToLower())
            {
                case "a":
                    {
                        Console.WriteLine("Pounds to kilograms Unit Conversion");
                        Total = (Value / 2.2046);
                       
                        break;
                    }
                case "b":
                    {
                        Console.WriteLine("kilograms to pounds Unit Conversion");
                        Total = (Value * 2.2046);
                     
                        break;
                    }
                case "c":
                    {
                        Console.WriteLine(" ounces to litres Unit Conversion");
                        Total = (Value * 33.8140226);
                        break;
                    }
                case "d":
                    {
                        Console.WriteLine(" litres to ounces Unit Conversion");
                        Total = (Value / 33.8140226);
                        break;
                    }
                case "e":
                    {
                        Console.WriteLine("inches centimeters Unit Conversion");
                        Total = ( Value / 0.39370);
                        break;
                    }
                case "f":
                    {
                        Console.WriteLine("centimeters to Unit Conversion");
                        Total = (Value * 0.39370);
                        break;
                    }
                case "g":
                    {
                        Console.WriteLine("fahrenheit to celcius Unit Conversion");
                        Total = ((Value - 32) / 1.8);
                        break;
                    }
                case "h":
                    {
                        Console.WriteLine("celcius to fahrenheit  Unit Conversion");
                        Total = ((Value * 1.8) + 32);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("The letter entered is invalid");
                        break;
                    }

            }
            Console.WriteLine($"Answer=\t {Total}" );


            
        }
    }
}
