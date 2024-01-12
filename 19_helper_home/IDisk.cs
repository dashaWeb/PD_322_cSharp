using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_helper_home
{
    interface IDisk
    {
        string Read();
        void Write(string text);
    }
}
