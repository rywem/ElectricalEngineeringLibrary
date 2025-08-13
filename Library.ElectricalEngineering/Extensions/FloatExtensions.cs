using RW.Library.ElectricalEngineering.Math;
using RW.Library.ElectricalEngineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW.Library.ElectricalEngineering.Extensions
{
    public static class FloatExtensions
    {
        public static bool IsApproximatelyEqual(this float value1, float value2, float tolerance = 1e-6f)
        {
            return System.MathF.Abs(value1 - value2) < tolerance;
        }
        public static float ToRadians(this float degrees)
        {
            return degrees * (System.MathF.PI / 180.0f);
        }
        public static float ToDegrees(this float radians)
        {
            return radians * (180.0f / System.MathF.PI);
        }
        public static Fraction ToFraction(this float value, float tolerance = 1e-6f)
        {
            var fraction = FractionHelper.DecimalToFraction(value, tolerance);
            return fraction;
        }
    }
}
