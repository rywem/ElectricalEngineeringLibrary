using ElectricalEngineeringHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringHelper.Math
{
    public static class FractionHelper
    {
        // A method to convert a decimal number to a fraction
        public static Fraction DecimalToFraction(double decimalNumber, double tolerance = 1e-10)
        {
            if (System.Math.Abs(decimalNumber) < tolerance)
            {
                return new Fraction(0, 1); // Return 0 as a fraction
            }
            int sign = System.Math.Sign(decimalNumber);
            decimalNumber = System.Math.Abs(decimalNumber);
            int numerator = 1;
            int denominator = 1;
            double fractionValue = (double)numerator / denominator;
            while (System.Math.Abs(fractionValue - decimalNumber) > tolerance)
            {
                if (fractionValue < decimalNumber)
                {
                    numerator++;
                }
                else
                {
                    denominator++;
                    numerator = (int)(decimalNumber * denominator + 0.5); // Round to nearest integer
                }
                fractionValue = (double)numerator / denominator;
            }
            return new Fraction(sign * numerator, denominator);
        }
        public static Fraction FloatToFraction(float decimalNumber, float tolerance = 0.0000000001f)
        {
            if (System.Math.Abs(decimalNumber) < tolerance)
            {
                return new Fraction(0, 1); // Return 0 as a fraction
            }
            int sign = System.Math.Sign(decimalNumber);
            decimalNumber = System.Math.Abs(decimalNumber);
            int numerator = 1;
            int denominator = 1;
            double fractionValue = (double)numerator / denominator;
            while (System.Math.Abs(fractionValue - decimalNumber) > tolerance)
            {
                if (fractionValue < decimalNumber)
                {
                    numerator++;
                }
                else
                {
                    denominator++;
                    numerator = (int)(decimalNumber * denominator + 0.5); // Round to nearest integer
                }
                fractionValue = (double)numerator / denominator;
            }
            return new Fraction(sign * numerator, denominator);
        }
        public static Fraction DoubleToFraction(decimal decimalNumber, decimal tolerance = 0.0000000001m)
        {
            if (System.Math.Abs((double)decimalNumber) < (double)tolerance)
            {
                return new Fraction(0, 1); // Return 0 as a fraction
            }
            int sign = System.Math.Sign(decimalNumber);
            decimalNumber = System.Math.Abs(decimalNumber);
            int numerator = 1;
            int denominator = 1;
            decimal fractionValue = (decimal)numerator / denominator;
            while (System.Math.Abs(fractionValue - decimalNumber) > tolerance)
            {
                if (fractionValue < decimalNumber)
                {
                    numerator++;
                }
                else
                {
                    denominator++;
                    numerator = (int)System.Math.Round(decimalNumber * denominator, MidpointRounding.AwayFromZero);
                }
                fractionValue = (decimal)numerator / denominator;
            }
            return new Fraction(sign * numerator, denominator);
        }
    }
}
