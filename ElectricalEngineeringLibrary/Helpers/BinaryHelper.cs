using ElectricalEngineeringLibrary.Enums;
using ElectricalEngineeringLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.Helpers
{
    public static class BinaryHelper
    {
        public static DigitalSignalCollection ConvertBinaryString(string binary)
        {
            if(string.IsNullOrEmpty(binary))
                throw new ArgumentNullException($"Argument is null");
            if(IsBinaryString(binary) == false)
                throw new ArgumentException($"Argument is not a valid binary string: {binary}. Inputs must be only 0 or 1");

            DigitalSignalCollection signals = new DigitalSignalCollection();
            foreach (char c in binary)
            {
                if (c == '0')
                    signals.Add(DigitalSignal.Low);
                else if (c == '1')
                    signals.Add(DigitalSignal.High);
            }
            return signals;
        }

        public static string ToBinary(DigitalSignalCollection signals)
        {
            if (signals == null || signals.Count == 0)
                return "0";
            StringBuilder binary = new StringBuilder();
            foreach (var signal in signals)
            {
                binary.Append(signal == DigitalSignal.High ? '1' : '0');
            }
            return binary.ToString();
        }

        public static string ToBinary(int number, int minBits = 0)
        {
            if (minBits < 0)
                throw new ArgumentOutOfRangeException(nameof(minBits), "minBits cannot be negative.");

            // Determine sign bit
            char signBit = number < 0 ? '1' : '0';

            // Manually compute absolute value
            int value = number < 0 ? -number : number;

            // Convert absolute value to binary
            string binary = "";
            if (value == 0)
            {
                binary = "0";
            }
            else
            {
                while (value > 0)
                {
                    int remainder = value % 2;
                    binary = remainder.ToString() + binary;
                    value = value / 2;
                }
            }

            // Pad binary string (excluding sign bit) if needed
            if (minBits > 0 && binary.Length < minBits)
            {
                binary = binary.PadLeft(minBits, '0');
            }

            return signBit + binary;
        }
        public static string ToBinary(uint number)
        {
            if (number == 0)
                return "0";

            string binary = "";
            uint two = 2;
            while (number > 0)
            {
                uint remainder = number % two;
                binary = remainder.ToString() + binary;
                number = number / 2;
            }
            return binary;
        }

        public static bool IsBinaryString(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return false;
            foreach (char c in binary)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

    }
}
