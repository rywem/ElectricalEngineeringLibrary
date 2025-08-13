using RW.Library.ElectricalEngineering.Enums;
using RW.Library.ElectricalEngineering.Helpers;
using RW.Library.ElectricalEngineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW.Library.ElectricalEngineering.Tools
{
    public static class BinaryAdder
    {
        public static FullAdderResult AdderStep(DigitalSignal a, DigitalSignal b, DigitalSignal carryIn)
        {
            // Calculate sum and carry out
            DigitalSignal sum = (a ^ b) ^ carryIn;
            DigitalSignal carryOut = (a & b) | (a & carryIn) | (b & carryIn);

            return new FullAdderResult
            {
                Sum = sum,
                CarryOut = carryOut
            };
        }
        public static FullAdderResult AdderStepSignalHelper(DigitalSignal a, DigitalSignal b, DigitalSignal carryIn)
        {
            // Calculate sum and carry out
            DigitalSignal sum = SignalHelper.Xor(a, b, carryIn);
            //DigitalSignal carryOut = (a & b) | (a & carryIn) | (b & carryIn);
            DigitalSignal carryOut = SignalHelper.Or(
                SignalHelper.And(a, b),
                SignalHelper.And(a, carryIn),
                SignalHelper.And(b, carryIn)
            );
            return new FullAdderResult
            {
                Sum = sum,
                CarryOut = carryOut
            };
        }
    }
}
