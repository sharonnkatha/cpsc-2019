using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ParallelArrays
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Array sizing happens when you create the array
            int physicalsize = 25;

            //an array is a collection
            int[] driverArray = new int[physicalsize];
            string[] nameArray = new string[physicalsize];

            //the call statement to your method must match the
            //   parameter list of your method ex: 3 parameters , 3 arguments
            //arguments on the call statement are positional
            int logicalsize = ReadandloadArray(driverArray, physicalsize , nameArray);
            int sum = 0;

            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];

            }
            if (logicalsize > 0)
            {
                
                Console.WriteLine($"Quiz Total: {logicalsize}");
                Console.WriteLine($"Student                Mark");
                Console.WriteLine($"_______                ____");
                int index = 0;
                while (index < logicalsize)
                {
                    Console.Write($"{nameArray[index],-18}");
                    Console.WriteLine($"{driverArray[index]}".PadLeft(9));
                    index++;
                }
                FindHighandLow(driverArray, logicalsize);


                Console.WriteLine($"The average of the {logicalsize} numbers is {(double)sum / (double)logicalsize}");

            }
            else
            {
                Console.WriteLine($"You have no numbers to calculate an average.");
            }
        }
        static int ReadandloadArray(int[] myArray, int physicalsize , string[] nameArray)
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


            string readRecord = "";

            System.IO.StreamReader reader = null;

            //line item will be a counter indicating which colum on the currently read record 
            //we are dealing with
            //on the record , which colum of data will be separated by a comma (,)
            //two column record Candy Kane , 44
            //three colum record Candy Kane , Cpsc1012, 44  
            int RecordDataColumn = 0;
            try
            {

                reader = new System.IO.StreamReader(Full_Path_File_Name);
                readRecord = reader.ReadLine();


                while (readRecord != null && logicalsize < physicalsize)
                {
                    //store the data into the program variables
                    //how does one split the record into separate data columns
                    //the record is a string
                    //the data on tyhe string is separated by a coma (,)
                    //you can use the straing class method called .split(delimeter)
                    //the delimeter is the character used to separate the data values
                    //.split (',') returns an array of strings 
                    //
                    //pre-test loop:foreach()
                    //syntax:foreach (datatype placeholdername in collection)
                    //datatype can be a strongly declared datatype  (int ,double etc)
                    //      or you can use the declaration of var
                    // a var datatype is resolved at execution time
                    //placeholder is your variable name that you will use in your code to reference the currents of the 
                    //data you are processing
                    //in is a keyword 
                    //the collection is your original data collection
                    //why use for each 
                    //this method will a)check if theres any need to process the loop 
                    //                b)automatically moves to the next occurence in the collection
                    //                c)automatically sdtops when it reaches the end of the collection
                    //                d) this will process an unkwon number of items
                    //                e)starts at the beginning of your collection and goes to the end 
                    //                 f)yopur collection can be any value datatype set

                    foreach(var item in readRecord.Split(','))
                    {
                        if (RecordDataColumn == 0)
                        {
                            //name
                            nameArray[logicalsize] = item;
                        }
                        else
                        {
                            //number
                            myArray[logicalsize] = int.Parse(item);
                        }
                        //switch the record data colum indicator 
                        RecordDataColumn = 1;
                        //or RecordDataColumn ++ just change the if statement


                    }


                    logicalsize++;

                    // to get ready for the next record
                    //return Data column  indicator back to 0
                    RecordDataColumn = 0;
                    readRecord = reader.ReadLine();
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


        }
        static void FindHighandLow(int[] myArray, int logicalsize)
        {
            int highest = 0;

            int lowest = 100;

            int index = 0;
            while (index < logicalsize)
            {
                if (highest < myArray[index])
                {
                    highest = myArray[index];
                }
                if (lowest > myArray[index])
                {
                    lowest = myArray[index];
                }
                index++;
            }
            Console.WriteLine($"highest mark is {highest}");
            Console.WriteLine($"lowest mark is {lowest}");
        }
        }
}
