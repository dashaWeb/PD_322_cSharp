using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_EventHandler
{
    internal class Interviwer
    {
        public string Name { get; set; }
        // метод, що може бути обробнико події
        public void DoSomething(object sender, MyArgs args)
        {
            Console.WriteLine($"Interviwer {Name} notified about {args.Description}; Date {args.Date.ToShortDateString()}");
        }
    }
}
