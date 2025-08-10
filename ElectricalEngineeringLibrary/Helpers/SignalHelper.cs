using Library.ElectricalEngineering.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ElectricalEngineering.Helpers
{
    public static class SignalHelper
    {
        public static DigitalSignal And(DigitalSignal signal1, DigitalSignal signal2)
        {
            if (signal1 == DigitalSignal.High && signal2 == DigitalSignal.High)
                return DigitalSignal.High;
            return DigitalSignal.Low;
        }
        public static DigitalSignal And(params DigitalSignal[] signals)
        {
            if (signals.Length == 0)
                throw new ArgumentException("At least one signal must be provided.");
            foreach (var s in signals)
            {
                if (s != DigitalSignal.High)
                    return DigitalSignal.Low;
            }
            return DigitalSignal.High;
        }

        public static DigitalSignal Or(DigitalSignal signal1, DigitalSignal signal2)
        {
            if (signal1 == DigitalSignal.High || signal2 == DigitalSignal.High)
                return DigitalSignal.High;
            return DigitalSignal.Low;
        }
        public static DigitalSignal Or(params DigitalSignal[] signals)
        {
            foreach (var s in signals)
            {
                if (s == DigitalSignal.High)
                    return DigitalSignal.High;
            }
            return DigitalSignal.Low;
        }
        public static DigitalSignal Not(DigitalSignal signal)
        {
            return signal == DigitalSignal.High ? DigitalSignal.Low : DigitalSignal.High;
        }      
        public static DigitalSignal Nor(DigitalSignal signal1, DigitalSignal signal2)
        {
            return Not(Or(signal1, signal2));
        }
        public static DigitalSignal Nor(params DigitalSignal[] signals)
        {
            if (signals.Length == 0)
                throw new ArgumentException("At least one signal must be provided.");
            return Not(Or(signals));
        }
        public static DigitalSignal Xor(DigitalSignal signal1, DigitalSignal signal2)
        {
            return (signal1 != signal2) ? DigitalSignal.High : DigitalSignal.Low;
        }
        public static DigitalSignal Xor(params DigitalSignal[] signals)
        {
            if (signals.Length == 0)
                throw new ArgumentException("At least one signal must be provided.");

            int highCount = signals.Count(s => s == DigitalSignal.High);
            return (highCount % 2 == 1) ? DigitalSignal.High : DigitalSignal.Low;
        }
        public static DigitalSignal Nand(DigitalSignal signal1, DigitalSignal signal2)
        {
             return Not(And(signal1, signal2));
        }

        public static DigitalSignal Nand(params DigitalSignal[] signals)
        {
            return Not(And(signals));
        }

    }
}
