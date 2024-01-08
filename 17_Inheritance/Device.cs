using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Inheritance
{
    abstract public class Device
    {
        private string brand;
        public string Brand { get => brand; set => brand = value ?? "NoBrand"; }
        private double Price { get; set; }

        private string name;
        public string Name { get => name; set => name = String.IsNullOrWhiteSpace(value) ? "NoName" : value; }

        protected virtual bool HasBattery { get => false; }
        internal int Memory { get; set; }
        public override string ToString()
        {
            return $"\t Brand :: {Brand}; \n\t Name :: {Name}; \n\t Price :: {Price};\n\t HasBattery :: {HasBattery}; \n\t Memory :: {Memory}";
        }
    }
}
