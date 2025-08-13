using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW.Library.ElectricalEngineering.Enums
{
    public enum DigitalSignal
    {
        Low = 0,
        High = 1,
    }

    public static class SignalExtensions
    {
        public static string ToFriendlyString(this DigitalSignal signal)
        {
            return signal switch
            {
                DigitalSignal.Low => "Low",
                DigitalSignal.High => "High",
                _ => throw new ArgumentOutOfRangeException(nameof(signal), signal, null)
            };
        }
        public static bool ToBoolean(this DigitalSignal signal)
        {
            return signal switch
            { 
                DigitalSignal.Low => false,
                DigitalSignal.High => true,
                _ => throw new ArgumentOutOfRangeException(nameof(signal), signal, null)
            };
        }        
    }
}
