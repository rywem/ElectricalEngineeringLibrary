using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ElectricalEngineering.Models
{
    public class Factor
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Product => Number1 * Number2;
    }
}
