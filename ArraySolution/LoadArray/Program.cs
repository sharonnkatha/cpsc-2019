using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*arrays are a fixed siz collection of a single datatype
             * array names hold an internal adress to the actual physical adrress 
             * InsufficientMemoryException location
             * a single item in the array is an == array element
             * declaring an array requires knowing the 
             *     a.physical siza
             *     b the elements to initialize the array
             *     
             *     a.array declared by physical size
             *     
            */
            int[] physicallyDeclared = new int[7]; //7 elements

            //b. the elements to initialize the array
            //  the number of values specifies the physical array size 
            //  each supplied value is placed within the array coonsequtively
            //  the datatype after the new is optional BUT the values given 
            //      must match the receivig array declaration datatype
            
            int[] diceValue = new int[] { 1, 2, 3, 4, 5, 6, };

            //the ohysically declared array has an initial default 
            //  value for each element depending on the system default value of the array datatype

            for (int index= 0; index < 7; index ++)
            {
                Console.WriteLine($"PhysicallyDeclared array element {index + 1} located at index " +
                    $"has a value of {physicallyDeclared[index]}"); 
            }
            
            for (int index = 0; index <6; index ++)
            {
                Console.WriteLine($"diceValue array element {index + 1} located at index " +
                   $"has a value of {diceValue[index]} ");
            }
                                            //OR
            int pDSize = 7;
            for (int index = 0; index < pDSize; index++)
            {
                Console.WriteLine($"PhysicallyDeclared array element {index + 1} located at index " +
                    $"has a value of {physicallyDeclared[index]} ");
            }

            int dvSize = diceValue.Length;
            for (int index = 0; index < dvSize; index++)
            {
                Console.WriteLine($"diceValue array element {index + 1} located at index " +
                   $"has a value of {diceValue [index]} ");
            }
            Console.ReadKey();
        }
    }
}
