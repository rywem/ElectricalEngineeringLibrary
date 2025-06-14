using ElectricalEngineeringHelper.Math;
using ElectricalEngineeringHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringHelper.Extensions
{
    public static class DoubleExtensions
    {
        public static bool IsApproximatelyEqual(this double value1, double value2, double tolerance = 1e-10)
        {
            return System.Math.Abs(value1 - value2) < tolerance;
        }
        public static double ToRadians(this double degrees)
        {
            return degrees * (System.Math.PI / 180.0);
        }
        public static double ToDegrees(this double radians)
        {
            return radians * (180.0 / System.Math.PI);
        }
        public static Fraction ToFraction(this double value, double tolerance = 1e-10)
        {
            var fraction = FractionHelper.DecimalToFraction(value, tolerance);
            return fraction;
        }
    }
}
