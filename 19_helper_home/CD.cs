using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_helper_home
{
    class CD : Disk, IRemoveableDisk
    {
        private bool hasDisk = true;
        public bool HasDisk => hasDisk;

        public void Insert()
        {
            Console.WriteLine("Call method Insert");
        }

        public void Reject()
        {
            Console.WriteLine("Call method Reject");
        }
    }
}
