using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Purpose Compute t5he bill for a gravel company
            Input:  enter the amount og gravel they wish to purchase
                    Choose if they want delivery or not
                    
            Process(es) If how much gravel they want
                        If GravelAmount< 1000 
                        
                        iftrue display 1000 price per lb = 0.55
                       
                        Ask if they want delivery 
                        Do you require delivery (Y/N)? y if Ythey will be charged for delivery
                        input formula to calculate GST and delivery charge
                        Else if 1000-2000 = 0.45
                        if true display 

                        


            Output: Display weight purchased , chargte, subtotal , delivery chage
                    GST and the Total
            Author: Sharon Nkatha
            Last modified: 2020-01-31
            */
            double GravelAmount = 2000 ;
            
            
            string msg = "";

            Console.WriteLine("Welcome to Stoney Gravel Pit!");

            Console.WriteLine("Please enter the weight of gravel required:");
            string inputValue = Console.ReadLine();
            GravelAmount = double.Parse(inputValue);


            Console.WriteLine("Do you require delivery (Y/N)?")
           


            if (GravelAmount < 1000)     // Main if
            {
                msg = ("The charge for {GravelAmount} of gravel is $0.55 per lb");
            }
            else if (GravelAmount > 1000 || GravelAmount < 2000)
            {
                msg = ("The charge for {GravelAmount} of gravel is $0.45 per lb");
            }
            else if (GravelAmount > 2000 || GravelAmount < 3000)
            {
                msg = ("The charge for {GravelAmount} of gravel is $0.35 per lb");
            }
            else if (GravelAmount > 3000 || GravelAmount < 4000)
            {
                msg = ("The charge for {GravelAmount} of gravel is $0.25 per lb");
            }
            else if (GravelAmount > 4000 || GravelAmount < 5000)
            {
                msg = ("The charge for {GravelAmount} of gravel is $0.15 per lb");
            }
            else                                 //main else
            {
                msg = ("The charge for {GravelAmount} of gravel is $0.10 per lb");
            }

            




        }
    }
}
