using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2
{
    class Program
    {
        public static object TOUppercase { get; private set; }

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

                        


            Output: Display weight purchased , charge, subtotal , delivery charge
                    GST and the Total
            Author: Sharon Nkatha
            Last modified: 2020-01-31
            */
            double gravelAmount;  //weight in pounds
            string inputValue;
            decimal gravelCharge;  //price per lb
            string deliveryOption;
            double subTotal;
            decimal GST;
            decimal deliveryCharge;
            double Total;
           

            Console.WriteLine("Welcome to Stoney Gravel Pit!");
            Console.WriteLine($"Please enter the weight of gravel required:");
            inputValue = Console.ReadLine();
            gravelAmount = double.Parse(inputValue);
            
            if (gravelAmount < 1000)
            {
                
                Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.55 per lb");

            }
            else if (gravelAmount >= 1000 || gravelAmount <= 2000)
            {
                
                Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.45 per lb");

            }
            else if (gravelAmount > 2000 || gravelAmount <= 3000)
            {
              
                Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.35 per lb");
            }
            else if (gravelAmount > 3000 || gravelAmount <= 4000)
            {
               
                Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.25 per lb");
            }
            else if (gravelAmount > 4000 || gravelAmount <= 5000)
            {
                
                Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.15 per lb");
            }
            else
            {
                
                Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.10 per lb");
            }

            //if (gravelAmount < 1000)
            //    {
            //    gravelCharge = 0.55m;
            //    Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.55 per lb");

            //}
            //else
            //{
            //    if (gravelAmount >= 1000 || gravelAmount <= 2000 )
            //    {
            //        gravelCharge = 0.45m;
            //        Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.45 per lb");

            //    }
            //    else
            //    {
            //        if (gravelAmount > 2000 || gravelAmount <= 3000)
            //        {
            //            gravelCharge = 0.35m;
            //            Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.35 per lb");

            //        }
            //        else
            //        {
            //            if (gravelAmount > 3000 || gravelAmount <= 4000)
            //            {
            //                gravelCharge = 0.25m;
            //                Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.25 per lb");

            //            }
            //            else
            //            {
            //                if (gravelAmount > 4000 || gravelAmount <= 5000 )
            //                {
            //                    gravelCharge = 0.15m;
            //                    Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.15 per lb");

            //                }
            //                else
            //                {
            //                    gravelCharge = 0.10m;
            //                    Console.WriteLine($"The Charge for  {gravelAmount}lb is $0.10 per lb");

            //                }
            //            }
            //        }
            //    }
            //}
            subTotal = gravelAmount * (double)gravelCharge;

            //switch statement
            Console.WriteLine($"Do you require delivery (Y/N)?");
            deliveryOption = Console.ReadLine();

            switch (deliveryOption.ToUpper())
            {
                case "Y":
                    {
                        deliveryCharge  = 0.03m * (decimal)subTotal;
                        break;
                    }
                case "N":
                    {
                        deliveryCharge = 0.00m;
                        break;
                    }
               
            }
            


            Console.WriteLine("\n");

            //Table display
            //subTotal = gravelAmount * (double)gravelCharge;
            Console.WriteLine($"subtotal:\t {subTotal:c}");

            //deliveryCharge = 0.03m * (decimal)subTotal;
            Console.WriteLine($"Delivery:\t{deliveryCharge:c}");

            GST =  ((decimal)subTotal + deliveryCharge) * 0.05m;
            Console.WriteLine($"GST:\t {GST:c}");

            Total = subTotal + (double)deliveryCharge +(double) GST;
            Console.WriteLine($"Total:\t{Total:c}");

           
            Console.WriteLine("\n\n");
            Console.WriteLine($"Thank you for your purchase! We hope your day rocks.");


            //Console.WriteLine($"{s,13:$#,###.00} {taxAmount,15:c}");

            //Console.WriteLine($"Subtotal: {subTotal,5:c}");
            //Console.WriteLine($"Delivery: {deliveryCharge,5:c}");
            //Console.WriteLine($"GST: {GST,10:c}");
            //Console.WriteLine($"Total: {Total,8:c}");
            Console.ReadKey();







        }
    }
}
