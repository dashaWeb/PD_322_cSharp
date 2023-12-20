using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Matrix_indexers
{
    internal class Matrix
    {
        int[,] matrix;
        public Matrix(int rows = 2, int cols = 2)
        {
            matrix = new int[rows, cols];
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(100);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append($"{matrix[i, j],7}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public int this[int r, int c]
        {
            get => matrix[r, c];
            set => matrix[r, c] = value;
        }
    }
}
