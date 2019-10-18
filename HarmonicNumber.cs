//-----------------------------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Program to find harmonic number
    /// </summary>
    public class HarmonicNumber
    {
        /// <summary>
        /// Prints the harmonic number.
        /// </summary>
        public void PrintHarmoniNumber()
        {
            try
            {
                Utility utility = new Utility();
                Console.WriteLine("Enter Number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Harminc number is : " + utility.HarmoniNumber(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Please Enter Integer Input Only");
            }
        }
    }
}
