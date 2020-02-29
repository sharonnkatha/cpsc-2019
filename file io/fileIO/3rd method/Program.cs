using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_method
{
   

    class Program
    { //this is required when using open file dialog
        [STAThread]
        static void Main(string[] args)
        {
           
                    string Full_Path_File_Name = "";
                    
                    OpenFileDialog fd = new OpenFileDialog();
                    fd.ShowDialog();
                    Full_Path_File_Name = fd.FileName;

                    string readValue = "";

                    //use a variable to count the rows in the file (optional)
                    int counter = 0;

                     //include "user friendly error handling" 
                    // this is your try/catch/finally structure
                    //the finally portion is ONLY needed if you need to close
                    StreamReader reader = null;                //    connection to a data source
            try
               {
                //in the try is the code you will attemot to execute
                //if an error happens during the execution of the code 
                //  an exception is thrown by the system
                //any exception thrown by the system is passed to the 
                //   catch{} coding block for processing

                    reader = new StreamReader(Full_Path_File_Name);
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
               }//end of try
            catch(Exception ex)
            {
                //.message hold the error that occurred during the processing of the code in your try{...}
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                //this is used if you need to close a data source such as an open file
                reader.Close();
            }
                    Console.ReadKey();
                }
            }
        }

   
