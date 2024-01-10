using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    class Duck : IFly, IMove, ISwim
    {

        // 
        public int Speed => 3;/**/
        int IFly.Speed => 15;

        int IMove.Speed => 5;

        public virtual void Fly()
        {
            Console.WriteLine($"Duck can fly with :: {((IFly)this).Speed}");
        }

        public void Move()
        {
            Console.WriteLine($"Duck can move with :: {((IMove)this).Speed}");
        }

        public void Swim()
        {
            Console.WriteLine($"Duck can swim");
        }

    }
}
