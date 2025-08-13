using RW.Library.ElectricalEngineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW.Library.ElectricalEngineering.Math
{
    public static class FactorHelper
    {
        // Get the list of multiples of a specified number
        public static List<Factor> GetFactors(int number)
        {
            if (number <= 0)
                throw new ArgumentException("Number must be greater than zero.");
            List<Factor> factors = new List<Factor>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(new Factor { Number1 = i, Number2 = number / i });
                }
            }
            return factors;
        }
    }
}
