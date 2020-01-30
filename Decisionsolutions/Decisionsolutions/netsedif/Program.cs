using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casedecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeLetter = "a";
            string percentageRange;

            //a case structure can be used when you have a single argument value compared to a 
            //series of literal values
            //
            //the structure begins with the switch (argument value) {....}
            //within the switch structure you have "cases"
            //a "case" represents one "oif" test against the argument value
            //the case must end with a "break;" command
            //the break sends your execution to the end of the switch structure
            //the last case in youyr switch ius a special case called' defaut"
            //"defaul" does not test against a literal value
            //default executes if none of the previous cases were executed
            //you can have multiple case statements coded for a particular case coding block
            //multiple case statements for a particular case coding bvlock imply logical OR  || tests
            //the case test is a relational (==) test

            switch(gradeLetter.ToUpper())  //took the letter and temporarily changed it to a capital //.ToLower() will change it to cfapital letter
            {
           
                case "A":
                    {
                        //logic for this particular case
                        percentageRange = "85 - 100";
                        break;
                    }
                case "B":
            
                    {
                        //logic for this particular case
                        percentageRange = "70 - 84";
                        break;
                    }
                case "C":
               
                    {
                        //logic for this particular case
                        percentageRange = "55- 69";
                        break;
                    }

                case "D":
                    {
                        //logic for this particular case
                        percentageRange = "40- 54";
                        break;
                    }
               
                case "F":
                    {
                        //logic for this particular case
                        percentageRange = "0 - 39";
                        break;
                    }
                default:
                    {
                        //the implied test on this case is none of the above
                        percentageRange = "invalid letter grade!";
                        break;
                    }
            }//eos

            Console.WriteLine($"your grade letter ({gradeLetter}) is {percentageRange}");
            Console.ReadKey();    //when using the debugging to stop


            //switch (gradeLetter)
            //{
            //    case "a":
            //    case "A":
            //        {
            //            //logic for this particular case
            //            percentageRange = "85 - 100";
            //            break;
            //        }
            //    case "B":
            //    case "b":
            //        {
            //            //logic for this particular case
            //            percentageRange = "70 - 84";
            //            break;
            //        }
            //    case "C":
            //    case "c":
            //        {
            //            //logic for this particular case
            //            percentageRange = "55- 69";
            //            break;
            //        }
            //    case "d":
            //    case "D":
            //        {
            //            //logic for this particular case
            //            percentageRange = "40- 54";
            //            break;
            //        }
            //    case "f":
            //    case "F":
            //        {
            //            //logic for this particular case
            //            percentageRange = "0 - 39";
            //            break;
            //        }
            //    default:
            //        {
            //            //the implied test on this case is none of the above
            //            percentageRange = "invalid letter grade!";
            //            break;
            //        }
            //}//eos

            //Console.WriteLine($"your grade letter ({gradeLetter}) is {percentageRange}");
            //Console.ReadKey();    //when using the debugging to stop

        }
    }
}
