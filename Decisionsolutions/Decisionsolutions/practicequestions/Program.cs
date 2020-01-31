using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicequestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            
            
            int number;
            number = 2;
           if (number > 0 )
            {
                Console.WriteLine("positive");
            }
           else
            {
                Console.WriteLine("Negative");
            }

            //Question 2

            int age;
            age = 60;
            string msg;
            if (age == 6 && age < 6) ;
            {
                msg = "$0.00";
            }
            if (age >= 7 && age <= 17) ;
            {
                Console.WriteLine("$9.80");
            }
            if (age >= 18 || age <= 54) ;
            {
                Console.WriteLine("$11.35");
            }


            Console.WriteLine();
        }
    }
}
