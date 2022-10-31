using System;
using System.Collections.Generic;
using System.Drawing;
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
        /// <summary>
        /// Gets the rise with 2 y cords (double)
        /// </summary>
        /// <param name="y1">The first Y cord (double)</param>
        /// <param name="y2">The second Y cord (double)</param>
        /// <returns>The rise (double)</returns>
        public static double GetRise(double y1, double y2)
        {
            return y2 - y1;
        }
        /// <summary>
        /// Gets the rise with 2 y cords (point)
        /// </summary>
        /// <param name="y1">The first Y cord (point)</param>
        /// <param name="y2">The second Y cord (point)</param>
        /// <returns>The rise (double)</returns>
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y);
        }
        /// <summary>
        /// Gets the run with 2 x cords (double)
        /// </summary>
        /// <param name="y1">The first x cord (double)</param>
        /// <param name="y2">The second x cord (double)</param>
        /// <returns>The run (double)</returns>
        public static double GetRun(double x1, double x2)
        {
            return x2 - x1;
        }
        /// <summary>
        /// Gets the run with 2 x cords (point)
        /// </summary>
        /// <param name="y1">The first x cord (point)</param>
        /// <param name="y2">The second x cord (point)</param>
        /// <returns>The run (double)</returns>
        public static double GetRun(Point p1, Point p2)
        {
            return GetRun(p1.X, p2.X);
        }

    }
}
