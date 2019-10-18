//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;

    /// <summary>
    /// Main method
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1 : Replace String");
                    Console.WriteLine("2 : Flip Coin");
                    Console.WriteLine("3 : Leap Year");
                    Console.WriteLine("4 : Power Of Two");
                    Console.WriteLine("5 : Harmonic Number");
                    Console.WriteLine("6 : Factors");
                    Console.WriteLine("7 : Exit");
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ReplaceString replaceString = new ReplaceString();
                            replaceString.ResultOfString();
                            break;
                        case 2:
                            FlipCoin flipCoin = new FlipCoin();
                            flipCoin.FlipCoinPercentage();
                            break;
                        case 3:
                            LeapYear leapYear = new LeapYear();
                            leapYear.CheckLeapYear();
                            break;
                        case 4:
                            PowerOfTwo powerOfTwo = new PowerOfTwo();
                            powerOfTwo.PrintPowerOfTwo();
                            break;
                        case 5:
                            HarmonicNumber harmoniNumber = new HarmonicNumber();
                            harmoniNumber.PrintHarmoniNumber();
                            break;
                        case 6:
                            Factors factors = new Factors();
                            factors.FindPrimeFactors();
                            break;
                        case 7:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Choice not found");
            }
        }
    }
}
