using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class TemperatureConverter
    {
        private int wait = 250;

        /// <summary>
        /// Called by the Main method
        /// </summary>
        public void Start(bool _continue)
        {
            do
            {
                DisplayMenu();
                var usersChoice = UsersChoice();
                Console.WriteLine("\n");
                _continue = SelectOption(usersChoice);
                Console.WriteLine("\n");
            }
            while (_continue);
        }

        /// <summary>
        /// Displays the input options and calls the appropriate conversion method based on the input
        /// </summary>
        private void DisplayMenu()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("               MAIN MENU");
            Console.WriteLine("****************************************");
            Console.WriteLine("   Convert Fahrenheit to Celsius    : 1");
            Console.WriteLine("   Convert Celsius to Fahrenheit    : 2");
            Console.WriteLine("   Exit the Converter               : 0");
            Console.WriteLine();
        }

        private int UsersChoice()
        {
            var choice = Input.ReadIntegerConsole("Enter 1, 2 or 0 ");
            Console.WriteLine("\n");

            Console.WriteLine("Your choice: {0}", choice);

            return choice;
        }
            
        private bool SelectOption(int choice)
        { 
            switch (choice)
                {            
                    case 1:
                        CalculateFahrenheitToCelsius();
                        return true;
                    case 2:
                        CalculateCelsiusToFahrenheit();
                        return true;
                    case 0:
                        return false;
                    default:
                        Thread.Sleep(wait);
                        Console.WriteLine("Invalid input...");
                        return true;
                }                               
        }

        /// <summary>
        /// Displays Celsius to Fahrenheit conversion from 0 to 100 degrees C
        /// </summary>
        private void CalculateCelsiusToFahrenheit()
        {
            for (int i = 0; i < 100; i += 4)
            {
                Thread.Sleep(wait);
                
                if (i == 96)
                {
                    Console.WriteLine("{0, 12:f2} C = {1, 8:f2} F {2, 16:f2} C = {3, 6:f2} F ", 
                        i, CelsiusToFahrenheit(Convert.ToDouble(i)), 
                        i += 4, CelsiusToFahrenheit(Convert.ToDouble(i)));
                    break;
                }
                else
                { 
                    Console.WriteLine($"{ i,12:f2} C = {CelsiusToFahrenheit(Convert.ToDouble(i)),8:f2} F " +
                    $"{i += 4,16:f2} C = {CelsiusToFahrenheit(Convert.ToDouble(i)),6:f2} F " +
                    $"{i += 4,20:f2} C = {CelsiusToFahrenheit(Convert.ToDouble(i)),4:f2} F ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Displays Fahrenheit to Celsius conversion from 0 to 210 degrees F
        /// </summary>
        private void CalculateFahrenheitToCelsius()
        {
            for (int i = 0; i <= 21; i++)
            {
                Thread.Sleep(wait);
                if( i == 21)
                {
                    Console.WriteLine($"{Convert.ToDouble(10 * i),12:f2} F = {FahrenheitToCelsius(Convert.ToDouble(10 * i++)),8:f2} C");
                }
                else
                {
                    Console.WriteLine($"{Convert.ToDouble(10 * i),12:f2} F = {FahrenheitToCelsius(Convert.ToDouble(10 * i++)),8:f2} C" +
                    $"{Convert.ToDouble(10 * i),16:f2} F = {FahrenheitToCelsius(Convert.ToDouble(10 * i++)),6:f2} C" +
                    $"{Convert.ToDouble(10 * i),20:f2} F = {FahrenheitToCelsius(Convert.ToDouble(10 * i)),4:f2} C");
                }                
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Converts input from Celsius to Fahrenheit
        /// </summary>
        private double CelsiusToFahrenheit(double celsius)
        {
            var fahrenheit = (double)9 / 5 * celsius + 32;
            return fahrenheit;
        }

        /// <summary>
        /// Converts input from Fahrenheit to Celsius
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        private double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (double)5 / 9 * (fahrenheit - 32);
            return celsius;
        }
    }
}
