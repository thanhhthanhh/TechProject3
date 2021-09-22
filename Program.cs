/*
    Author: Thanh Nguyen
    Date: 09/21/2021
    Comment: This C# Console Application code use an Iterative Statement 
             to conver from Kilometers to Miles for the Manager.
*/

using System;

namespace TechProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input the Kilometers
            Console.WriteLine(" Please enter the Kilometer Increment Value: ");

            /*
                Use the try catch block to validate user input.
                If the user provides bad input, the catch block
                will handle the error and a message will be displayed.
             */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();

                // This variable will be used to perform the various iterative statements 
                int value_input = int.Parse(input);

                /*
                 This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                  Depending on the value of the user input between 10 and 25, a different type of
                iterative statement will execute.
                 */

                // If the value of user input is between 10 and 25, execute a For Loop
                if ((value_input >= 10) && (value_input <= 25))
                {
                    Console.WriteLine(" Kilometer Increment Value = " + value_input.ToString() + "KM.");
                    Console.WriteLine(" Kilometers                  Equivalent Miles");
                    // Create the Loop  when KM <=200
                    int kilometer = 0;
                    const double miles_conversion = 0.621371;

                    // The While Loop
                    while (kilometer <= 200)
                    {
                        double miles = kilometer * miles_conversion;
                        Console.WriteLine("      " + kilometer.ToString() +      "                       " + miles.ToString());
                        kilometer = kilometer + value_input;
                    } // End of While
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true); // Close the program
                } // End of IF

                // If the user does not enter a value between 10 and 25, display a message
                else
                {
                    Console.WriteLine("Please try enter an integer between 10 and 25 again ...");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                } // End of ELSE
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an interger value and try running the program one more time...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            } // End of Catch
        } // End of Main
    } // End of class
} // End of namespace
