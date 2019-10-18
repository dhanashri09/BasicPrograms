//-----------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Program to print power of two
    /// </summary>
    public class PowerOfTwo
    {
        /// <summary>
        /// Prints the power of two.
        /// </summary>
        public void PrintPowerOfTwo()
        {
            try
            {
                Utility utility = new Utility();
                Console.WriteLine("Enter the value");
                int value = Convert.ToInt32(Console.ReadLine());
                while (value > 31)
                {
                    Console.WriteLine("Enter value less than 31");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                utility.PowerOfTwo(value);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
        }
    }
}
