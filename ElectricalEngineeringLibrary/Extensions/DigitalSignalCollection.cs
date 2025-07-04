using ElectricalEngineeringLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalEngineeringLibrary.Extensions
{
    public class DigitalSignalCollection : List<DigitalSignal>
    {
        public List<int> ToIntList()
        {
            return this.Select(signal => signal == DigitalSignal.High ? 1 : 0).ToList();
        }

        public List<bool> ToBoolList()
        {
            return this.Select(signal => signal.ToBoolean()).ToList();
        }
    }
}
