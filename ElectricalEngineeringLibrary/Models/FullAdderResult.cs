﻿using ElectricalEngineeringLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.Models
{
    public class FullAdderResult
    {
        public DigitalSignal Sum { get; set; }
        public DigitalSignal CarryOut { get; set; }
    }
}
