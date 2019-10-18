//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Program to check whether the year is leap year or not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Checks the leap year.
        /// </summary>
        public void CheckLeapYear()
        {
            try
            {
                Utility utility = new Utility();
                Console.WriteLine("Enter year to check whether the it is leap year or not : ");
                int year = Convert.ToInt32(Console.ReadLine());
                while (year <= 999 || year > 9999)
                {
                    Console.WriteLine("Please enter correct input");
                    Console.WriteLine("Enter year in 4 digit");
                    year = Convert.ToInt32(Console.ReadLine());
                }

                if (utility.IsLeapYear(year))
                {
                    Console.WriteLine(year + " is leap year");
                }
                else
                {
                    Console.WriteLine(year + " is not leap year");
                }
            }
           catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
        }
    }
}
