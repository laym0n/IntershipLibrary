using System;

namespace IntershipLibrary
{
    public class AreaOf
    {
        public static double circle(double radius) => radius * radius * Math.PI;
        public static double triangle(double a, double b, double c)
        {
            double ans, max, side1, side2;
            (max, side1, side2) = (a > b && a > c) ? (a, b, c) : (b > a && b > c) ? (b, a, c) : (c, b, a);
            if (side1 * side1 + side2 * side2 == max * max)
                ans = side1 * side2 / 2;
            else
            {
                double p = (a + b + c) / 2;
                ans = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return ans;
        }
    }
}
