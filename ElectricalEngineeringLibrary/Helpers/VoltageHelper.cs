using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.Helpers
{
    public static class VoltageHelper
    {
        /// <summary>
        /// A method to calculate voltage from a voltage divider circuit
        /// </summary>
        /// <param name="inputVoltage">The input voltage</param>
        /// <param name="resistor1">Resistance from resistor 1</param>
        /// <param name="resistor2">Resistance from resistor 2</param>
        /// <returns>A voltage at the divider</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CalculateVoltageFromDivider(double inputVoltage, double resistor1, double resistor2)
        {
            if (resistor1 <= 0 || resistor2 <= 0)
            {
                throw new ArgumentException("Resistor values must be greater than zero.");
            }
            // Voltage divider formula: Vout = Vin * (R2 / (R1 + R2))
            double outputVoltage = inputVoltage * (resistor2 / (resistor1 + resistor2));
            return outputVoltage;
        }

        // A method to calculate voltage from a current and resistance
        public static double CalculateVoltageFromCurrent(double current, double resistance)
        {
            if (resistance <= 0)
            {
                throw new ArgumentException("Resistance must be greater than zero.");
            }
            return current * resistance; // Voltage (V) = Current (I) * Resistance (R)
        }

    }
}
