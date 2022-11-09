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
        /// <summary>
        /// Gets the distance between 2 points, with double inputs
        /// </summary>
        /// <param name="x1">This is the first points x value</param>
        /// <param name="y1">This is the first points y value</param>
        /// <param name="x2">This is the seconds points x value</param>
        /// <param name="y2">This is the seconds points y value</param>
        /// <returns>The distance between the points</returns>
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return GetHypotenuse((GetRise(y1,y2)), (GetRun(x1,x2)));
        }
        /// <summary>
        /// This gets the slope with 4 points
        /// </summary>
        /// <param name="x1">The x value of point 1</param>
        /// <param name="y1">The y value of point 1</param>
        /// <param name="x2">The x value of point 2</param>
        /// <param name="y2">The y value of point 2</param>
        /// <returns>The slope</returns>
        public static double GetSlope(double x1, double y1, double x2, double y2)
        {
            return GetRise(y1, y2) / GetRun(x1, x2);
        }
        /// <summary>
        /// Gets the slop from 2 points
        /// </summary>
        /// <param name="P1">Point 1</param>
        /// <param name="P2">Point 2</param>
        /// <returns>The slope</returns>
        public static double GetSlope(Point P1, Point P2)
        {
            return GetSlope(P1.X, P1.Y, P2.X, P2.Y);
        }
        /// <summary>
        /// Reverses a string
        /// </summary>
        /// <param name="str">Your string</param>
        /// <returns>The reverse of the string</returns>
        public static string Reverse(string str)
        {
            string newString ="";
            for (int i = str.Length-1; i >=0 ; i--)
            {
                newString += str[i];
            }
            return newString;
        }
        /// <summary>
        /// Gets the circumference with the radius
        /// </summary>
        /// <param name="radius">radius of your circle</param>
        /// <returns>The circumference</returns>
        public static double Circumference(double radius)
        {
            return 2 * 3.14159265358979323846 * radius;
        }
        /// <summary>
        /// Takes a list of doubles and returns the average
        /// </summary>
        /// <param name="list">Your list</param>
        /// <returns>The average</returns>
        public static double GetAverage(List<double> list)
        {
            double average = 0;
            int count = 0;
            foreach(int i in list)
            {
                count++;
                average += i;
            }
            return average/ count;
        }
        /// <summary>
        /// Makes a random list of numbers
        /// </summary>
        /// <param name="max">max value of numbers in the list</param>
        /// <param name="min">min value of numbers in the list</param>
        /// <param name="size">how many numbers are in the list</param>
        /// <returns>the list of random numbers</returns>
        public static List<int> GetRandomList(int max, int min, int size)
        {
            Random generator = new Random();
            List<int> list = new List<int>();
            for(int i = 1; i <= size; i++)
            {
                list.Add(generator.Next(min,max));
            }
            return list;
        }
        /// <summary>
        /// Gets the Y intercept from slope and a point
        /// </summary>
        /// <param name="slope">The slope of the line</param>
        /// <param name="y1">The y value of the point</param>
        /// <param name="x1">The x value of the point</param>
        /// <returns>The y intercept of the line</returns>
        public static double GetYIntercept(double slope, int y1, int x1)
        {
            return (y1 - (slope * x1));
        }
        /// <summary>
        /// Gets the Y intercept from a slope and a point
        /// </summary>
        /// <param name="slope">Slope of the line</param>
        /// <param name="point">a point of the line</param>
        /// <returns>The Y intercept of the line</returns>
        public static double GetYIntercept(double slope, Point point)
        {
            return (point.Y - (slope * point.X));
        }
        /// <summary>
        /// Gets a random array from the max, min and size
        /// </summary>
        /// <param name="max">Max value in the array</param>
        /// <param name="min">Min value in the array</param>
        /// <param name="size">Size of the array</param>
        /// <returns>The array</returns>
        public static int[] GetRandomArray(int max, int min, int size)
        {
            Random generator = new Random();
            int[] list = new int[size];
            for (int i = 1; i <= size; i++)
            {
                list[i]=(generator.Next(min, max));
            }
            return list;
        }
    }
}
