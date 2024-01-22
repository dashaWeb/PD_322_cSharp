using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    delegate void PositionDelegate(string desc); // визначили тип делегату для події NewPosition
    internal class Company // publisher
    {
        public string Name { get; set; }
        public event PositionDelegate NewPosition; // подія - екземпляр делегату
        public void AddPosition(string descriptor) // логіка
        {
            NewPosition?.Invoke(descriptor); // ініціювання події
        }

    }
}
