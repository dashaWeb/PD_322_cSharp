using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Inheritance
{
    internal class TV : Device
    {
        public int Weight { get; set; }
        public int Diagonal { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\n\t Weight :: {Weight}; \n\t Diagonal :: {Diagonal};";
        }
        protected override bool HasBattery => true;
    }
}
