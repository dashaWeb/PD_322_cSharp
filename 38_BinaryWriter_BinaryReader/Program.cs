using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_BinaryWriter_BinaryReader
{
    internal class Program
    {
        static void BinaryWriterDemo()
        {
            string fname = "my.dat";
            using(BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create,FileAccess.Write)))
            {
                string text = "Test line .... Тестовий рядок";
                int value = 12;
                double valueD = 25.3;
                int[] arr = { 10, 20, 30, 40, 50 };


                bw.Write(text);
                bw.Write(value);
                bw.Write(valueD);
                bw.Write(arr.Length);
                foreach (var item in arr)
                {
                    bw.Write(item);
                }

            }
        }
        static void BinaryReaderDemo()
        {
            string fname = "my.dat";
            using(BinaryReader br = new BinaryReader(new FileStream(fname,FileMode.Open,FileAccess.Read)))
            {
                string res = br.ReadString();
                Console.WriteLine($"Read String {res}");
                Console.WriteLine($"Read String {br.ReadInt32()}");
                Console.WriteLine($"Read String {br.ReadDouble()}");
                var length = br.ReadInt32();
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arr[i] = br.ReadInt32();
                    Console.Write($"{arr[i],7}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //BinaryWriterDemo();
            Console.OutputEncoding = Encoding.UTF8;
            BinaryReaderDemo();
        }
    }
}
