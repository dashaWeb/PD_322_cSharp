using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    internal class Interviwer // subsriber
    {
        public string Name { get; set; }
        // метод, що може бути обробнико події
        public void DoSomething(string desc)
        {
            Console.WriteLine($"Interviwer {Name} notified about {desc}");
        }
    }
}
