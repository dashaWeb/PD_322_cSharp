using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_helper_home
{
    class Director : ICloneable
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Director(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public object Clone()
        {
            return new Director(Name, LastName);
        }
        public override string ToString()
        {
            return $"Name :: {Name,-10} LastName :: {LastName,-10}";
        }
    }
}
