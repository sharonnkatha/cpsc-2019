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
           
            int Mark=0;
            string InputValue;
            string Name;
            string gradeletter = "";
            int loopCounter=1;

            Console.WriteLine("Please enter your name ");
            InputValue = Console.ReadLine();
            Name = InputValue;
            while (loopCounter <= 7)
            {

                Console.WriteLine("Please enter your Mark ");
                InputValue = Console.ReadLine();
                Mark = int.Parse(InputValue);

                if (Mark >= 90)
                {
                    gradeletter = "A";
                }

                else
                {
                    if (Mark >= 80)
                    {
                        gradeletter = "B";
                    }
                    else
                    {
                        if (Mark >= 70)
                        {
                            gradeletter = "C";
                        }
                        else
                        {
                            if (Mark >= 60)
                            {
                                gradeletter = "D";
                            }
                            else
                            {
                                if (Mark >= 50)
                                {
                                    gradeletter = "E";
                                }
                                else
                                {
                                    gradeletter = "F";
                                }
                            }

                        }
                    }


                }
                

                Console.WriteLine($"{Name} your Mark of {Mark} translates to {gradeletter}");
                Console.WriteLine("\n\n");
                loopCounter++;
            }    
            
        }    
    }
}
