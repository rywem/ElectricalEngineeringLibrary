using ElectricalEngineeringLibrary.Enums;
using ElectricalEngineeringLibrary.Extensions;
using ElectricalEngineeringLibrary.Helpers;
using ElectricalEngineeringLibrary.Models;
using ElectricalEngineeringLibrary.Tools;
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
            //var x = -17;
            int num1 = 200;
            int num2 = -3100;

            int num1BitCount = BinaryHelper.GetBitCount(num1);  
            int num2BitCount = BinaryHelper.GetBitCount(num2);
            int maxBitCount = Math.Max(num1BitCount, num2BitCount);
            var collectionNum1 = BinaryHelper.ConvertBinaryString(BinaryHelper.ToBinary(num1, maxBitCount));
            var collectionNum2 = BinaryHelper.ConvertBinaryString(BinaryHelper.ToBinary(num2, maxBitCount));

            var result = new DigitalSignalCollection();
            DigitalSignal carryIn = DigitalSignal.Low;
            for (int i = collectionNum1.Count-1; i > 0; i--)
            {
                var adderResult = BinaryAdder.AdderStepSignalHelper(collectionNum1[i], collectionNum2[i], carryIn);
                result.Add(adderResult.Sum);
                carryIn = adderResult.CarryOut;
            }
            result.Add(carryIn); // Add the final carry out
            result.Reverse(); // Reverse the result to match the original order
            var resultString = BinaryHelper.ToBinary(result); // Convert result to binary string
            var resultInt = BinaryHelper.ToInteger(resultString); // Convert result to integer
            Console.WriteLine(resultInt);
        }
    }
}
