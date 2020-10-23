using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Figure
{/// <summary>
 ///  Class of belonging of a point to a trapezoid
 /// </summary>
    public class BeloningPoints
    {/// <summary>
     /// Point check method
     /// </summary>
     /// <param name="cordinates"></param>
        static public void CheckPoints(Cordinates cordinates)
        {
            var trapezeInstance = new Trapeze();

            double[] side = trapezeInstance.CalcSideLenght(cordinates);
            Console.Clear();
            int cordinateX, X;
            int cordinateY, Y;
            Console.WriteLine("Enter x cordinate");
            while (!Int32.TryParse(Console.ReadLine(), out X))
                Console.WriteLine("Error");
            cordinateX = X;

            Console.WriteLine("Enter y cordinate");


            while (!Int32.TryParse(Console.ReadLine(), out Y))
            {
                Console.WriteLine("Error");
            }

            cordinateY = Y;



            if (cordinateY >= 0 && cordinateY <= cordinateX * cordinateX &&
            cordinateY <= cordinates.secondCordinate * cordinates.secondCordinate &&
            cordinateX >= cordinates.firstCordinate && cordinateX <= cordinates.secondCordinate)
            {
                Console.WriteLine("Point beloning trapeze");
            }
            else Console.WriteLine("Point not beloning trapeze");
        }


    }
}
