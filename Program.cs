//C# console application a no-user input Array with an array size of 25 which is manually populated
//The code then displays a total of 25 outputs displaying the element value



using System;

namespace Class_Project___Deliverable_3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables and manual array list of 25 values
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            int count = 0;
           

            //display the array to show "Element value  = n" for each element in the array
            foreach (int element in numbers)
            {
                count++;
                Console.WriteLine($"Element Value {count}:= {element}");
            }

          
            //user is prompted to press any key to exit
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("Press any key to exit the program ...");
          
        }
    }
}

