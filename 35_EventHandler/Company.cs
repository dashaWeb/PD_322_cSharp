using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_EventHandler
{
    class MyArgs:EventArgs
    {
        public string Description { get; set; }
        public DateTime Date => DateTime.Now;
    }
    internal class Company
    {
        public string Name { get; set; }
        public event EventHandler<MyArgs> NewPosition; // подія - екземпляр делегату
        public void AddPosition(string descriptor) // логіка
        {
            MyArgs args= new MyArgs()
            {
                Description= descriptor,
            };
            NewPosition?.Invoke(this,args); // ініціювання події
        }
    }
}
