//-----------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// program to find the percentage of head and tail
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// Flips the coin percentage.
        /// </summary>
        public void FlipCoinPercentage()
        {
            try
            {
                Utility utility = new Utility();
                Console.WriteLine("Enter number of time to flip the coin : ");
                int number = Convert.ToInt32(Console.ReadLine());
                utility.PrintFlipCoinPercentage(number);
            }
           catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
        }
    }
}
