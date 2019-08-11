using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// the Input class was NOT written by Johnathan Beal
/// </summary>
namespace Assignment2
{

    /// <summary>
    /// This is a class with shared functions that are used to check the user's input
    /// and make sure that it belongs to the class that the calling function needs.
    /// </summary>
    /// <remarks></remarks>
    /// 
    public class Input
    {
        /// <summary>
        /// Reads a whole number from the console and checks to see if it is a valid input
        /// </summary>
        /// <param name="messageToUser"></param>
        /// <returns></returns>
        public static int ReadIntegerConsole (string messageToUser)
        {
            // Reads from the console until a correct integer is received
            bool goodNumber = false;
            int convertedValue = 0;

            do
            {
                //Show the message (method parameter) to the user
                Console.Write ( messageToUser );

                goodNumber = int.TryParse ( Console.ReadLine ( ), out convertedValue );

                if (!goodNumber)
                    Console.Write ( "Invalid input. Please try again: " );
            } while (!goodNumber);

            return convertedValue;
        }

        /// <summary>
        /// Reads a double from the console and checks to see if it is a valid input.
        /// Includes a recursive call
        /// </summary>
        /// <returns></returns>
        public static double ReadDoubleConsole ( )
        {
            // Reads from the console until a correct double is received
            double input = 0;
            if (double.TryParse ( Console.ReadLine ( ), out input ))
            {
                return input;
            }
            else
            {
                Console.Write ( "Wrong input. Please try again: " );
                return ReadDoubleConsole ( );
            }
        }

        /// <summary>
        /// Reads a decimal from the console and checks to see if it is a valid input
        /// </summary>
        /// <returns></returns>
        public static decimal ReadDecimalConsole ( )
        {
            // Reads from the console until a correct decimal is received
            decimal input = default ( decimal );
            if (decimal.TryParse ( Console.ReadLine ( ), out input ))
            {
                return input;
            }
            else
            {
                Console.Write ( "Wrong input. Please try again: " );
                return ReadDecimalConsole ( );
            }
        }

    }


}
