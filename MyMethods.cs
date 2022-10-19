using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMethods
{
    internal class MyMethods
    {
        /// <summary>
        /// Returns the hypotenuse of a right triangle given the sides a and b.
        /// </summary>
        /// <param name="a">Length of side a</param>
        /// <param name="b">Length of side b</param>
        /// <returns>Length of side c</returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt((a * a) + (b * b));
        }

    }
}
