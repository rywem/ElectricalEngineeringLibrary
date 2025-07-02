using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.ReturnTypes
{
    public class StaticDisciplineResult
    {
        public bool OutputLowCompatible { get; set; }
        public bool OutputHighCompatible { get; set; }

        public bool FullyCompatible => OutputLowCompatible && OutputHighCompatible;

        public override string ToString()
        {
            return $"Output LOW Compatible: {OutputLowCompatible}\n" +
                   $"Output HIGH Compatible: {OutputHighCompatible}\n" +
                   $"Overall Compatibility: {FullyCompatible}";
        }
    }

}
