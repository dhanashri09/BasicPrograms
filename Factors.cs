//-----------------------------------------------------------------------
// <copyright file="Factors.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Program to find prime factors of a number
    /// </summary>
    public class Factors
    {
        /// <summary>
        /// Finds the prime factors.
        /// </summary>
        public void FindPrimeFactors()
        {
            try
            {
                Utility utility = new Utility();
                Console.WriteLine("Enter number to find prime factors : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prime factors of the number " + number + " is :");
                utility.PrimeFactor(number);
            }
           catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
        }
    }
}
