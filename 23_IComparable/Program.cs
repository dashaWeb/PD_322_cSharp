using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            Console.WriteLine(auditory);

            Console.WriteLine("\n\n");

            auditory.Sort();

            Console.WriteLine(auditory);

            Console.WriteLine("\n\n");

            auditory.Sort(new DateComparer());

            Console.WriteLine(auditory);

            Console.WriteLine("\n\n");
        }
    }
}
