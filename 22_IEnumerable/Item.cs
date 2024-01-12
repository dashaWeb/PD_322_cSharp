using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_IEnumerable
{
    class Item
    {
        public string Name { get; set; }
        public uint Price { get; set; }
        public override string ToString()
        {
            return $"Product :: {Name,-10} Price :: {Price,-7}";
        }
    }
}
