using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public static class Calculator
    {

        public static double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));

        }

        public static double CalcTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }
    }
}
