//-----------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Program to replace a string
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Results the of string.
        /// </summary>
        public void ResultOfString()
        {
            try
            {
                Utility utility = new Utility();
                Regex regex = new Regex("[*a-zA-Z]");
                string name = new string("Hello <<UserName>>, How Are You");
                Console.WriteLine("Enter the name");
                string replace = Console.ReadLine();
                while (regex.IsMatch(replace))
                {
                    string result = utility.ReplaceName(name, replace);
                    Console.WriteLine(result);
                    replace = Convert.ToString(Console.ReadLine());
                }
                
                    Console.WriteLine("Enter valid input");
                    replace = Convert.ToString(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid number");
            }
        }
    }
}
