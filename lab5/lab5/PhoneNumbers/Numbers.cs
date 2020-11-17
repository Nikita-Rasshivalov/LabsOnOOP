using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneNumbers
{
    public class Numbers
    {
        public static void ParseNumbers(List<string> mobileNumbers, List<string> numbersWithoutCode, List<string> simpleNumbers)
        {
            string fullForm = @"^(\+375|80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$";
            string formWithoutCode = @"^(29|25|44|33)(\d{3})(\d{2})(\d{2})$";
            string simpleForm = @"^(d{3})(\d{2})(\d{2})$";

            foreach (var number in mobileNumbers)
            {
                
                var delSpace = number.Trim();
                if (Regex.IsMatch(delSpace, fullForm))
                {
                    mobileNumbers.Add(delSpace);
                   
                }

                if (Regex.IsMatch(delSpace, formWithoutCode))
                {
                    numbersWithoutCode.Add(delSpace);
                    
                }
                if (Regex.IsMatch(delSpace,simpleForm))
                {
                    simpleNumbers.Add(delSpace);
                }
            }
        }
    }
}