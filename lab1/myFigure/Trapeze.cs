using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{    /// <summary>
     /// class - trapezoid.
     /// </summary>
    public class Trapeze
    {
        public double[] side = new double[4] { 0, 0, 0, 0 };

        /// <summary>
        ///  Method for calculating the lengths of the sides of a trapezoid
        /// </summary>
        /// <param name="cordinates"></param>
        /// <returns>return values of side lenhth </returns>
        public double[] CalcSideLenght(Cordinates cordinates)
        {

            const int epsilon = 1000;
            double step, x;
            side[0] = cordinates.secondCordinate - cordinates.firstCordinate;
            side[1] = Math.Sqrt(Math.Pow(cordinates.firstCordinate, 4));
            side[2] = Math.Sqrt(Math.Pow(cordinates.secondCordinate, 4));
            step = (cordinates.secondCordinate - cordinates.firstCordinate) / epsilon;
            x = cordinates.firstCordinate;
            side[3] = 0;
            for (int i = 0; i < epsilon; i++)
            {
                side[3] += Math.Sqrt(1 + Math.Pow(1 / Math.Cos(x), 2)) * step;
                x += step;
            }

            

            return side;

        }
        /// <summary>
        /// Method for calculating the perimeter of a trapezoid 
        /// </summary>
        /// <param name="cordinates">Some coordinates</param>
        /// <returns>returns value of perimetr </returns>
        public double CalcPerimetr(Cordinates cordinates)
        {

            CalcSideLenght(cordinates);
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += side[i];

            }
            

            return sum;
        }
        /// <summary>
        ///  Method for calculating the area of ​​a trapezoid
        /// </summary>
        /// <param name="cordinates"></param>
        /// <returns>return value of square</returns>
        public double CalcSquare(Cordinates cordinates)
        {
            const int epsilon = 1000;
            double step, x, integralSquare = 0;
            step = (cordinates.secondCordinate - cordinates.firstCordinate) / epsilon;
            x = cordinates.firstCordinate;
            for (int i = 0; i < epsilon; i++)
            {
                integralSquare += x * x * step;
                x += step;
            }
            
            return (integralSquare);
        }






    }
}
