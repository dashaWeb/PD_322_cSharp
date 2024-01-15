using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Generic_class
{
    interface IStack<T>
    {
        void Push(T item);
        void Pop();
        bool Full();
        T Peek();
    }
}
