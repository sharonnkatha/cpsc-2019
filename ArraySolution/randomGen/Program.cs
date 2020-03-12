using System;

namespace randomGen
{
    class Program
    {//if it is declared outside of a method add the keyword static in fornt of your declaration
        //if declared outside of a method BUT within the class Then the variable is know to all 
        //methods WITHOUT having to pass the value as a parameter
               //DONT do thjis for the coreportfolio
            //static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Random is adatatype of class (object)
            //Random is just the defination of the object (describes the object)
            //Random is not a physical instance of the object
            //to get a physical instance of the objest use the keyword new
            //new is used by anyobject to create an instance of thaat object

            //To identify the object instance datatype , add the class name after the keyword new
            //Random is datatype
            //rnd is the variable name of the objet instance
            //new is the command keyword to create an object instance
            //Random() is the type of object instance new is to create


            Random rnd = new Random();
            int[] myArray = new int[10];
            for (int i=0; i<10; i++)
            {
                myArray[i] = rnd.Next(1, 100);
                Console.WriteLine($"index {i} has a value of {myArray[i]} ");
            }

            //what is the highest random number generated and the lowest random number generated
            int highest = 0;
            int lowest = 100;

            int loopCounter = 0;
            while (loopCounter < 10)
            {
                if (highest < myArray[loopCounter])
                {
                    highest = myArray[loopCounter];
                }
                if (lowest < myArray[loopCounter])
                {
                   lowest = myArray[loopCounter];
                }
                loopCounter++;
            }
            Console.WriteLine("\n\n");
            Console.WriteLine($"highest value is {highest}");
            Console.WriteLine($"lowest value is {lowest}");
            Console.ReadKey();
        }
        static void someMethod (Random paramRnd)
        {

        }
    }
}
