using ElectricalEngineeringLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.Models
{
    public class DeviceStaticDisciplineModel
    {
        public StaticDisciplineBehavior OutputBehavior { get; set; } // Behavior of the Output Signal
        public StaticDisciplineBehavior InputBehavior { get; set; } // Behavior of the Input Signal
    }

    public class StaticDisciplineBehavior
    {
        public StaticDisciplineSignalType SignalType { get; set; } // Output or Input
        public double HighThreshold { get; set; } // High Threshold Voltage
        public double LowThreshold { get; set; } // Low Threshold Voltage
    }
}
