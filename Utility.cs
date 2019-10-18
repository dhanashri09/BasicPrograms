//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Utility class for all programs
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Replaces the name.
        /// </summary>
        /// <param name="name">The name is the input string.</param>
        /// <param name="replace">The replace is a string to be replaced.</param>
        /// <returns> It returns replaced name in string</returns>
        public string ReplaceName(string name, string replace)
        {
            name = name.Replace("<<UserName>>", replace);
            return name;
        }

        /// <summary>
        /// Prints the flip coin percentage.
        /// </summary>
        /// <param name="number">The number.</param>
        public void PrintFlipCoinPercentage(int number)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 1);
            double head = 0;
            double tail = 0;
            for (int i = 0; i < number; i++)
            {
                if (randomNumber > 0.5)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }

            Console.WriteLine("Head percentage is : " + ((float)(head / number) * 100));
            Console.WriteLine("Tail percentage is :" + ((float)(number - head) / (number * 100)));
        }

        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        /// <summary>
        /// Powers the of two.
        /// </summary>
        /// <param name="power">The power is the number to generate power of two.</param>
        public void PowerOfTwo(int power)
        {
            int value = 1;
            for (int i = 1; i <= power; i++)
            {
                value = value * 2;
                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// Harmonic the number.
        /// </summary>
        /// <param name="number">The number to find the harmonic number.</param>
        /// <returns>returns harmonic number</returns>
        public double HarmoniNumber(int number)
        {
            double harmonic = 0.0;
            for (int i = 1; i <= number; i++)
            {
                harmonic += 1 / (float)i;
            }

            return harmonic;
        }

        /// <summary>
        /// Primes the factor.
        /// </summary>
        /// <param name="number">The number to find the prime factor.</param>
        public void PrimeFactor(int number)
        {
            for (int i = 2; i <= number;)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    number = number / i;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
