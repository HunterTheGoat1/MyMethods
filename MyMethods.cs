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
        /// Returns the hypotenuse of a right triangle given the length of both legs.
        /// </summary>
        /// <param name="legOne">Length of leg one</param>
        /// <param name="legTwo">Length of leg two</param>
        /// <returns>Length of the hypotenuse</returns>
        public static double GetHypotenuse(double legOne, double legTwo)
        {
            return Math.Sqrt((legOne * legOne) + (legTwo * legTwo));
        }
        /// <summary>
        /// Returns the length of the other leg given the length of the hypotenuse and other leg.
        /// </summary>
        /// <param name="hypot">Length of the hypotenuse</param>
        /// <param name="otherLeg">Length of the other leg</param>
        /// <returns>Length of the hypotenuse</returns>
        public static double GetLeg(double hypot, double otherLeg)
        {
            return Math.Sqrt((hypot * hypot) - (otherLeg * otherLeg));
        }

    }
}
