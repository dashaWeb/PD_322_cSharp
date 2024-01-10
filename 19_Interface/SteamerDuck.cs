using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    class SteamerDuck : Duck, IFly
    {
        public override void Fly()
        {
            Console.WriteLine($"SteamerDuck can not fly");
        }
    }
}
