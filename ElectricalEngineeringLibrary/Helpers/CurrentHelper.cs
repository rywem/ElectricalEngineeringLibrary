using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.Helpers
{
    public static class CurrentHelper
    {
        /// <summary>
        /// method to calculate current in an electrical circuit from voltage and resistance
        /// </summary>
        public static double CalculateCurrent(double voltage, double resistance)
        {
            if (resistance <= 0)
                throw new ArgumentException("Resistance must be greater than zero.");
            return voltage / resistance; // Current (I) = Voltage (V) / Resistance (R)
        }
        /// <summary>
        /// A static method to calculate current in an electrical circuit from power and voltage
        /// </summary>
        public static double CalculateCurrentFromPower(double power, double voltage)
        {
            if (voltage <= 0)
                throw new ArgumentException("Voltage must be greater than zero.");
            return power / voltage; // Current (I) = Power (P) / Voltage (V)
        }

        /// <summary>
        /// A method to calculate the current from a current divider circuit
        ///</summary>
        public static double CalculateCurrentFromDivider(double inputCurrent, double resistor1, double resistor2)
        {
            if (resistor1 <= 0 || resistor2 <= 0)
            {
                throw new ArgumentException("Resistor values must be greater than zero.");
            }
            // Current divider formula: Iout = Iin * (R1 / (R1 + R2))
            double outputCurrent = inputCurrent * (resistor1 / (resistor1 + resistor2));
            return outputCurrent;
        }
    }
}
