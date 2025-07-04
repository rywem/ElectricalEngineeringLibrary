using ElectricalEngineeringLibrary.Enums;
using ElectricalEngineeringLibrary.Helpers;
using ElectricalEngineeringLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringConsole.Examples
{
    /// <summary>
    /// Foundations of Analog and Digital Circuits - By Agarwal, Anant; Lang, Jeffrey; Chapter 5 Examples
    /// </summary>
    public class ChapterFiveExamples
    {
        public static void Ch5Point2()
        {
            var yikesStaticDiscipline = new DeviceStaticDisciplineModel
            {
                OutputBehavior = new StaticDisciplineBehavior
                {
                    SignalType = StaticDisciplineSignalType.Output,
                    HighThreshold = 3.0,
                    LowThreshold = 1.0
                },
                InputBehavior = new StaticDisciplineBehavior
                {
                    SignalType = StaticDisciplineSignalType.Input,
                    HighThreshold = 4,
                    LowThreshold = 1.5
                }
            };

            var discoStaticDiscipline = new DeviceStaticDisciplineModel
            {
                OutputBehavior = new StaticDisciplineBehavior
                {
                    SignalType = StaticDisciplineSignalType.Output,
                    HighThreshold = 4.0,
                    LowThreshold = 1.5
                },
                InputBehavior = new StaticDisciplineBehavior
                {
                    SignalType = StaticDisciplineSignalType.Input,
                    HighThreshold = 3.5,
                    LowThreshold = 2.0
                }
            };
            //Console.WriteLine(result.ToString());
        }

        public static void Ch5OneBitAdder()
        {
            // Example of a one-bit adder using digital signals
            var x = -17;
            Console.WriteLine(BinaryHelper.ToBinary(x)); // Convert to binary string
            Console.WriteLine(BinaryHelper.ToBinary(5));             // 0101
            Console.WriteLine(BinaryHelper.ToBinary(-5));            // 1101
            Console.WriteLine(BinaryHelper.ToBinary(5, 8));          // 00000101
            Console.WriteLine(BinaryHelper.ToBinary(-5, 8));         // 10000101
            Console.WriteLine(BinaryHelper.ToBinary(5, 2));          // 0101
            Console.WriteLine(BinaryHelper.ToBinary(0, 4));          // 0000
            Console.WriteLine(BinaryHelper.ToBinary(0));             // 00
        }
    }
}
