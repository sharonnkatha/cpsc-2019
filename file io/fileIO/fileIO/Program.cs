using System;
using System.IO; //namespaces required to do fileIo

namespace fileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";
            //the  file will always be and always be in the same location
            //you can prompt for the file name
            //
            //location 
            //set up the path name

            string FolderPath = @"c:\Users\snkatha1\Documents\Github\cpsc-2019\";

            //i will assume that the required file will always be found at the
            //  root of the course class repository

            Console.Write("Enter the file name ex myfile.txt\t");
            string FileName = Console.ReadLine();

            Full_Path_File_Name = FolderPath + FileName;

            //set for reading a file
            //string variable is requires to receive the data for the file
            //the string will be filled with one row from your file
            //   on each file read
            string readValue = "";

            //use a variable to count the rows in the file (optional)
            int counter = 0;

            //add the .Net Framework classthat contains the code that will do the read of the file
            //required io class for reading is streamReader locatyed in the 
            //   namespace systen.IO
            //to attch the reader to the file you need to pass the 
            //   full path file name (fully qualified file name)
            //   as an argument to the class while it is being created
            //the reader is referred to as an instance of the class
            //the istance is created when the new command is used in conjuction 
            //    with the class name
            //
            StreamReader reader = new StreamReader(Full_Path_File_Name);
            //gets a single row off the file
            readValue = reader.ReadLine();
            
            //if your line was read is "null" you have reached the end of the file
            //   eof end of file
            while (readValue != null) //stop when you rerach the end of the file
            {
                counter++;
                Console.WriteLine($"File Line {counter} has a value of {readValue}");

                //get the next line
                readValue = reader.ReadLine();

            }
            Console.ReadKey();
        }
    }
}
