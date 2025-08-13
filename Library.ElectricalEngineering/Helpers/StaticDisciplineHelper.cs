using RW.Library.ElectricalEngineering.Models;
using RW.Library.ElectricalEngineering.ReturnTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW.Library.ElectricalEngineering.Helpers
{
    public class StaticDisciplineHelper
    {
        public static StaticDisciplineResult CompareDevices(
            DeviceStaticDisciplineModel sender,
            DeviceStaticDisciplineModel receiver)
        {
            var result = new StaticDisciplineResult();

            // Logic 0: Sender's VOL must be ≤ Receiver's VIL
            result.OutputLowCompatible = sender.OutputBehavior.LowThreshold <= receiver.InputBehavior.LowThreshold;

            // Logic 1: Sender's VOH must be ≥ Receiver's VIH
            result.OutputHighCompatible = sender.OutputBehavior.HighThreshold >= receiver.InputBehavior.HighThreshold;

            return result;
        }

        public static StaticDisciplineResult CompareDevices(double senderHighVoltage, double senderLowVoltage, DeviceStaticDisciplineModel receiver)
        {
            return new StaticDisciplineResult
            {
                OutputLowCompatible = senderLowVoltage <= receiver.InputBehavior.LowThreshold,
                OutputHighCompatible = senderHighVoltage >= receiver.InputBehavior.HighThreshold
            };
        }
    }

}
