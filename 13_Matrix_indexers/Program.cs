using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Matrix_indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(5,10);
            Console.WriteLine(m);
            Console.WriteLine();
            m[2, 1] = -33;
            Console.WriteLine(m);
        }
    }
}
