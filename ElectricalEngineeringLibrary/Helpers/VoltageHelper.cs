using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.Helpers
{
    public static class VoltageHelper
    {
        // A method to calculate voltage from a voltage divider circuit
        public static double CalculateVoltage(double inputVoltage, double resistor1, double resistor2)
        {
            if (resistor1 <= 0 || resistor2 <= 0)
            {
                throw new ArgumentException("Resistor values must be greater than zero.");
            }
            // Voltage divider formula: Vout = Vin * (R2 / (R1 + R2))
            double outputVoltage = inputVoltage * (resistor2 / (resistor1 + resistor2));
            return outputVoltage;
        }

    }
}
