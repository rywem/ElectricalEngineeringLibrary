using Library.ElectricalEngineering.Math;
using Library.ElectricalEngineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ElectricalEngineering.Extensions
{
    public static class DecimalExtensions
    {
        public static bool IsApproximatelyEqual(this decimal value1, decimal value2, decimal tolerance = 1e-10M)
        {
            return System.Math.Abs((double)(value1 - value2)) < (double)tolerance;
        }
        public static decimal ToRadians(this decimal degrees)
        {
            return degrees * ((decimal)System.Math.PI / 180.0M);
        }
        public static decimal ToDegrees(this decimal radians)
        {
            return radians * (180.0M / (decimal)System.Math.PI);
        }
        public static Fraction ToFraction(this decimal value, decimal tolerance = 1e-10M)
        {
            var fraction = FractionHelper.DecimalToFraction((double)value, (double)tolerance);
            return fraction;
        }
    }
}
