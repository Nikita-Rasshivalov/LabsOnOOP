﻿using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace PhoneNumbers
{
    /// <summary>
    /// Class mobile numbers
    /// </summary>
    public class Numbers
    {
        /// <summary>
        /// Method of check mobile numbers
        /// </summary>
        /// <param name="mobileNumbers">Mobile number</param>
        /// <param name="fullNumbers">Full mobile number</param>
        /// <param name="numbersWithoutCode">Mobile number without code</param>
        /// <param name="simpleNumbers">Simple mobile number</param>
        public static void ParseNumbers(List<string> mobileNumbers, List<string> fullNumbers, List<string> numbersWithoutCode, List<string> simpleNumbers)
        {
            string fullForm = @"^(\+375|80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$";
            string formWithoutCode = @"^(29|25|44|33)(\d{3})(\d{2})(\d{2})$";
            string simpleForm = @"^(\d{3})(\d{2})(\d{2})$";
            foreach (var number in mobileNumbers)
            {
                var delSpace = number.Trim();
                if (Regex.IsMatch(delSpace, fullForm))
                {
                    fullNumbers.Add(delSpace);
                }

                if (Regex.IsMatch(delSpace, formWithoutCode))
                {
                    numbersWithoutCode.Add(delSpace);
                }
                if (Regex.IsMatch(delSpace, simpleForm))
                {
                    simpleNumbers.Add(delSpace);
                }
            }
        }
    }
}