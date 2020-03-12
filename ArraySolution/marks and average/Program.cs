using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int[] driverArray = new int[25];
            int logicalsize = ReadandloadArray(driverArray, 25);
            int sum = 0;

            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];

            }
            if (logicalsize > 0)
            {
                string name = "bob";
                Console.WriteLine($"quiz total {logicalsize}");
                Console.WriteLine("student      Mark");
                Console.WriteLine("-----------------");
                int index = 0;
                while (index < logicalsize)
                {
                    Console.Write($"{name,-7} ");
                    Console.WriteLine($"{driverArray[index]}".PadLeft(9));
                    index++;
                }
                FindHighandLow(driverArray ,logicalsize);
            }
            else
            {
                Console.WriteLine(" you have no numbers to calculate an average");
            }
        }
        static int ReadandloadArray(int[] myArray, int physicalsize)
        {

            //pass to your method a reference address
            //changes to the array within this method will alter the origibnal array in the main method
            //physical size is pass by value(a copy of the original value)
            //any change to the physical size REMAINS within this method and 
            //   does not affect the original value in main
            //
            int logicalsize = 0;


            string Full_Path_File_Name = "";

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;


            string readValue = "";




            System.IO.StreamReader reader = null;
            try
            {

                reader = new System.IO.StreamReader(Full_Path_File_Name);


                readValue = reader.ReadLine();


                while (readValue != null && logicalsize < physicalsize)
                {

                    myArray[logicalsize] = int.Parse(readValue);
                    logicalsize++;

                    //get the next line
                    readValue = reader.ReadLine();
                }
            } //eof try
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {

                if (reader != null)
                    reader.Close();
            }

            return logicalsize; //return the absolute value


        }//end of static
        static void FindHighandLow( int[] myArray , int logicalsize)
        {
            int highest = 0;
            int lowest = 100;
            int index = 0;

            int loopCounter = 0;
            while (index < logicalsize)
            {
                if (highest < myArray[loopCounter])
                {
                    highest = myArray[loopCounter];
                }
                if (lowest < myArray[loopCounter])
                {
                    lowest = myArray[loopCounter];
                }
                index++;
            }
            Console.WriteLine("\n\n");
            Console.WriteLine($"highest mark is {highest}");
            Console.WriteLine($"lowest mark is {lowest}");
        }//end of staic
    }
}
