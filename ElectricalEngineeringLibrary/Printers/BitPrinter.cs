using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.Printers
{
    public class BitPrinter
    {
        public static void PrintBitCombinations(int numBits)
        {
            Console.WriteLine($"===\tPrinting Bit Combinations\t=== ");
            Console.WriteLine($"===\t\tBit count {numBits}\t\t=== ");
            Console.WriteLine($"===\tTotal Combinations: {System.Math.Pow(2, numBits)}\t\t===");
            Console.WriteLine($"================================================");
            int totalCombinations = 1 << numBits; // 2^numBits
            int countNumber = 1;
            for (int i = 0; i < totalCombinations; i++)
            {
                Console.Write($"({countNumber++})\t");
                for (int bit = numBits - 1; bit >= 0; bit--)
                {
                    int bitValue = (i >> bit) & 1;
                    Console.Write(bitValue + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"================================================");
        }
    }
}
