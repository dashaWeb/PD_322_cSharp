﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_jugged_array
{
    internal class Program
    {
        static int[][] createJugged(int row, int col)
        {
            int[][] tmp = new int[row][];
            for (int i = 0; i < row; i++)
            {
                tmp[i] = new int[col++];
            }
            return tmp;
        }
        static void FillJugged(int[][] arr, int left = 10, int right = 50)
        {
            var rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(left, right + 1);
                }
            }
        }
        static void PrintJugged(int[][] arr)
        {
            /*for (int i = 0; i < arr.Length; i++) // по рядках
            {
                for(int j = 0; j < arr[i].Length; j++)// по стовпцях
                {
                    Console.Write($"{arr[i][j],-10}");
                }
                Console.WriteLine();
            }*/
            foreach (var line in arr) //по рядках
            {
                foreach (var item in line)//по стовпцях
                {
                    Console.Write($"{item,-10}");
                }
                Console.WriteLine();
            }
        }
        static void SwapRow(int[][] arr, int row1, int row2)
        {
            if(row1 >= 0 && row2 >= 0 && row1  < arr.Length && row2 < arr.Length)
            {
                int[] tmp = arr[row1];
                arr[row1] = arr[row2];
                arr[row2] = tmp;
            }
        }
        static void PushRow(ref int[][] arr,int size)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = new int[size];
        }
        static void SumInRow(int[][] arr)
        {
            /*int sum = 0;
            foreach (var line in arr)
            {
                foreach (var item in line)
                {
                    sum += item;
                }
                Console.WriteLine(sum);
                sum = 0;
            }*/
            /*foreach (var item in arr)
            {
                Console.WriteLine(item.Sum());
            }*/
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Sum in line {i} = {arr[i].Sum()}");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Min in line {i} = {arr[i].Min()}");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Max in line {i} = {arr[i].Max()}");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Average in line {i} = {arr[i].Average()}");
            }
        }
        static void Main(string[] args)
        {
            int[][] arr = createJugged(7, 4);
            FillJugged(arr);
            PrintJugged(arr);
            Console.WriteLine();

            SwapRow(arr, 2, 6);
            PrintJugged(arr);
            Console.WriteLine();

            PushRow(ref arr, 3);
            PrintJugged(arr);
            Console.WriteLine();

            Console.WriteLine("Result sum :: ");
            SumInRow(arr);
        }
    }
}
