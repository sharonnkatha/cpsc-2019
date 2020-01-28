using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchif_marinerstars
{
    class Program
    {
        static void Main(string[] args)
        {
            int StarLevel = 3;
            string msg = "";   //empty messsage string

            if (StarLevel < 1)  
            {
                msg = ("Welcome to Holland America Cruises.You have yet to earn speecial benefits");
            }
            else if (StarLevel<2)
            {
                msg = "You can receive any of the 1-star benefits of the mariner program";
            }
            else if (StarLevel<3)
            {
                msg = "You can receive any of the 2-star benefits of the mariner program";
            }
            else if (StarLevel<4)
            {
                msg = "You can receive any of the 3-star benefits of the mariner program";
            }
            else if (StarLevel<5)
            {
                msg = "You can receive any of the 4-star benefits of the mariner program";
            }
            else
            {
                msg = "You can receive any of the 5-star benefits of the mariner program";
               
            }
            Console.WriteLine(msg);
        }
    }
}
