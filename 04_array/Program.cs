using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_array
{
    internal class Program
    {
        static void PrintArray<T>(T[] arr, string prompt = "")
        {
            Console.Write(prompt);
            /*for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i],10}");
            }*/
            foreach (var item in arr)
            {
                Console.Write($"{item,10}");
            }
            Console.WriteLine();
        }
        static void FillRand(int[] arr, int left = 1, int right = 50)
        {
            if(left > right)
            {
                Swap(ref left, ref right);
            }
            var rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(left, right + 1);
            }
        }
        static void Swap<T>(ref T left, ref T right) // параметр передається за посиланням
        {
            var tmp = left;
            left = right;
            right = tmp;
        }
        static void PushBack<T>(ref T[] arr, T value)
        {
            // way 1
            /*int[] tmp = new int[arr.Length + 1];
            for (int i = 0; i <  arr.Length; i++)
            {
                tmp[i] = arr[i];
            }
            tmp[arr.Length] = value;
            arr = tmp;*/
            // way 2
            /*int[] tmp = new int[arr.Length + 1];
            arr.CopyTo(tmp, 0);
            tmp[arr.Length] = value;
            arr = tmp;*/
            // way 3
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length-1] = value;
        }
        static void Main(string[] args)
        {
            // value types (structs, int, double, enum) - копія значення
            // reference types (class, string, StringBuilder, interface, delegate, array)
            int[] arr = { 1, 2, 3, 5, 7 };
            Console.WriteLine(arr.Length);
            int size = 5; //int.Parse(Console.ReadLine());
            int[] mas = new int[size];
            PrintArray(arr, "Print Array :: ");
            FillRand(mas);
            PrintArray(mas, "Print rand array :: ");
            PushBack(ref mas, 333);
            PrintArray(mas, "Print rand array :: ");
            double[] arr2 = { 2.5, 3.6, 4.5, 0.2, 4.8 };
            PrintArray(arr2, "Print double array :: ");
            PushBack(ref arr2, 44.55);
            PrintArray(arr2, "Print double array :: ");
            PrintArray(mas, "\n\nPrint rand array :: ");
            Console.WriteLine( "Input value for search :: ");
            int value = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(mas, value);
            if(index != -1)
            {
                Console.WriteLine($"{value} was found in index {index}");
                int lastIndex = Array.LastIndexOf(mas, value);
                Console.WriteLine($"{value} was found in index {lastIndex}");
            }
            else
            {
                Console.WriteLine(  $"Value {value} not found");
            }
            //бібліотека Linq - методи розширення для роботи з масивом
            if(mas.Contains(value))
            {
                Console.WriteLine($"Value {value} was found");
            }
            else {
                Console.WriteLine($"Value {value} was not found");
            }
            FillRand(mas, -10,10);
            PrintArray(mas, "\n\nPrint rand array :: ");
            int indexFirstPositive = Array.FindIndex(mas, IsPositive);
            if(indexFirstPositive != -1)
            {
                Console.WriteLine($"Found posotive (first occur) {mas[indexFirstPositive]}");
            }
            else { Console.WriteLine("Not found any positive in array");
            }
            Console.WriteLine($"Number of positive elements :: {mas.Count(IsPositive)}");
            int[] positives = Array.FindAll(mas, IsPositive);
            PrintArray(positives, "Print all positive numbers :: ");
            // (formal params)=>{... retur ...};
            //int[] evens = Array.FindAll(mas, (int a) => { return a % 2 == 0; });
            int[] evens = Array.FindAll(mas, a => a % 2 == 0);
            PrintArray(evens, "Print all even numbers :: ");

            bool isAllPositive = Array.TrueForAll(mas, e => e > 0);
            Console.WriteLine($"All positive elements :: {isAllPositive}");

            int div = 5;
            bool exists = Array.Exists(mas, e => e % div == 0);
            Console.WriteLine($"Does exist divisable by {div} :: {exists}");

            Array.Sort(mas);
            PrintArray(mas, "Print sort array asc :: ");

            Array.Reverse(mas);
            PrintArray(mas, "Print reverse array asc :: ");

            string[] words = { "jan", "feb", "april", "august", "sept", "nov" };
            PrintArray(words, "Print words array :: ");
            Array.Sort(words);
            PrintArray(words, "Print sort words array :: ");
            Array.Sort(words, (s1, s2) => s1.Length.CompareTo(s2.Length));
            PrintArray(words, "Print sort by length array :: ");

        }

        static bool IsPositive(int number)
        {
            return number > 0;
        }
    }
}
