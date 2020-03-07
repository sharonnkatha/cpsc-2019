using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    { [STAThread]
        static void Main(string[] args)
        {
            //declare an int array of 25 elements
            int[] myArray = new int[25];
            //int variable to inndicate the logical size of the array
            //the logical size refers to the number of elements in tyhe array
            //the declared size (25) is referred to as physical size
            int logicalsize = 0;
            int physicalsize = 25;

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

            Console.WriteLine($"The number of elements in the array is {logicalsize}");
            for(int loopcounter = 0; loopcounter < logicalsize; loopcounter ++)
            {
                Console.WriteLine($"At array index {loopcounter} there is a value of {myArray[loopcounter]}");
            }
            Console.ReadKey();


            //sequential search
            //is it there
            Console.Write($"Enter a number:\t");
            int searcharg = int.Parse(Console.ReadLine());
            //count the number of  occurences in loop
            bool found = false;
            int searchindex = 0;
            
            //condition expression
            //  a)continue to look until youve looked at everything
            //  b)continue if not foud
            //searchcounter is a index (0 based)
            //logicalsize is natural count (1 based))

            
            while (searchindex < logicalsize && !found) //look inside
            {
                if (myArray[searchindex] == searcharg)
                {

                    //number was foind
                    // stop
                    //search counter will be the index of the array location where 
                    //    the searcharg was first found
                    found = true;
                }
                else
                {
                    //increment to look at the next element in the array
                    searchindex++;
                }   //go onto the next item
            }
           if (found)
            {
                Console.WriteLine($"{searcharg} was found at index {searchindex}");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found in the {logicalsize} array element");
            }



            //this could also be coded using a for loop because you are looking at all the elements
            //     (exactcount)
            //for (int searchindex = 0; searchindex < logicalsize; seachindex++ )
            //I do not want to stop whwn i find the first occurence in thew loop
            //IS there another way to terminate the loop instead of using logical size
            int foundcount = 0;
            while (searchindex < logicalsize && !found) //look inside
                {
                    if (myArray[searchindex] == searcharg)
                    {

                        //number was foind
                        // stop
                        //search counter will be the index of the array location where 
                        //    the searcharg was first found
                        found = true;
                      foundcount++;
                    }
                    
                        //increment to look at the next element in the array
                        searchindex++;
                    
                }
            //if (foundcoount > 0)then you would not need a boolean found flag
            if (found)
            {
                Console.WriteLine($"{foundcount} occurences of {searcharg} were located in the array");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found anywhere in the {logicalsize} array element");
            }

        }
    }}
