using _17_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDevice
{
    internal class SmartPhone: Device
    {
        public string Phone { get; set; }
        protected override bool HasBattery => true;
        public override string ToString()
        {
            return base.ToString() + $"\n\t Phone :: {Phone}";
        }
    }
}
