using System;

/// <summary>
/// This assignment was written by Johnathan Beal
/// </summary>
namespace Assignment2
{
    class Program
    {
        /// <summary>
        /// This is the starting point for running this application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TemperatureConverter tempCon = new TemperatureConverter();
            tempCon.Start(true);
        }
    }
}
