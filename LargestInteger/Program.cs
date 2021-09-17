using System;

namespace LargestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a pseudocode, then a C# app that input a series of 10 integers, 
            //then determines and displays the largest integer. 
            //Your app should use at least the following three variables:
            //counter: A counter to count to 10(i.e.:  to keep track of how many numbers 
            //have been input and to determine when all 10 numbers have been processed).
            //number: The integer most recently input by the user
            //largest: The largest number found so far


           //PSEUDOCODE

           //DECLARE number, largest, counter AS INTEGER
           //FOR counter = 1 TO 10
           //   PRINT ("Please input number: ")
           //   INPUT number
           //   IF number > largest 
           //       THEN
           //       largest = number
           //   END IF  
           //   counter = counter + 1
           //END FOR
           //PRINT "The largest number input is: " largest
            
            
            
            //Declaring Variables
            int number = 0, largest =0;

            for (int counter = 0; counter < 10; counter++) //counter starts at zero
            {
                Console.WriteLine("Please input number: ");
                number = int.Parse(Console.ReadLine());

                if (number > largest)
                {
                    largest = number;
                }

            }

            Console.WriteLine($"The largest number input is {largest}");
            Console.ReadLine();
        }
    }
}
