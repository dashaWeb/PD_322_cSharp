using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Exception
{
    class BadProductException : ApplicationException // неявно public
    {
        public DateTime ErrorDate { get; set; }
        public BadProductException(string message, DateTime dt)
            :base(message)
        {
            ErrorDate = dt;
        }
    }
}
