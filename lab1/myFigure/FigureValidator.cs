using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{/// <summary>
/// Class for figure validation
/// </summary>
    public class FigureValidator
    {
        /// <summary>
        /// Checks the figure for a trapezoid
        /// </summary>
        /// <param name="cordinates"></param>
        /// <returns>return figure existance</returns>
        public static bool CheckValidation(Cordinates cordinates)
        {
            const int minInterval = 0;
            const int maxInterval = 10;
            bool trapezeExist = false;

            if (cordinates.firstCordinate >= minInterval && cordinates.secondCordinate <= maxInterval || cordinates.firstCordinate == cordinates.secondCordinate)
            {
                Console.WriteLine("It is trapeze");
                trapezeExist = true;
            }
            else Console.WriteLine("It not trapeze");
            return trapezeExist;


        }
    }
}
