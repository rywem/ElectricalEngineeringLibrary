using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringConsole
{
    internal class MiscTests
    {
        public static double CalculateTotalCurrent(double resistance)
        {
            return resistance / (1.5 + .5 * resistance);
        }
    }
}
