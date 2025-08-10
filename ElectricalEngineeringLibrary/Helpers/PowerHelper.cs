using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ElectricalEngineering.Helpers
{
    public static class PowerHelper
    {
        /// <summary>
        /// a helper method to calculate power in an electrical circuit from voltage and current 
        /// </summary>
        /// <param name="voltage"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>        
        public static double CalculatePower(double voltage, double current)
        {
            if (voltage < 0 || current < 0)
                throw new ArgumentException("Voltage and current must be non-negative values.");
            return voltage * current; // Power (P) = Voltage (V) * Current (I)
        }

        // a helper method to calculate power in an electrical circuit from resistance and current
        public static double CalculatePowerFromResistance(double resistance, double current)
        {
            if (resistance <= 0 || current < 0)
                throw new ArgumentException("Resistance must be greater than zero and current must be non-negative.");
            return System.Math.Pow(current, 2) * resistance; // Power (P) = I^2 * R
        }
        // a helper method to calculate power in an electrical circuit from voltage and resistance 
        public static double CalculatePowerFromVoltage(double voltage, double resistance)
        {
            if (voltage < 0 || resistance <= 0)
                throw new ArgumentException("Voltage must be non-negative and resistance must be greater than zero.");
            return System.Math.Pow(voltage, 2) / resistance; // Power (P) = V^2 / R
        }
    }
}
