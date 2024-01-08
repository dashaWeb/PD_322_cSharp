using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Inheritance
{
    internal class SmartTV : TV
    {
        public bool Effect3D { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\n\t 3DEffect :: {Effect3D}";
        }
    }
}
