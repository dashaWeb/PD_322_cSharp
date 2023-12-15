using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_2DArray
{
    internal class Program
    {
        static void PrintMatrix(int[,] arr)
        {
            /*foreach (var item in arr)
            {
                Console.Write($"{item,10}");
            }*/
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j],10}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[,] arr =
            {
                { 7,5,6},
                {7,8,9 },
                {7,5,8 }
            };
            int[,] mas = new int[2, 3]
            {
                {20,30,10 },
                { 7,5,8}
            };
            PrintMatrix(arr);
            
        }
    }
}
