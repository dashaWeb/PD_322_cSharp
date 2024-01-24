using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_FileStream_demo_other_data_types
{
    internal class Program
    {

        static void WriteStr(string line, string path)
        {
            using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = Encoding.Unicode.GetBytes(line);
                fs.Write(buffer, 0, buffer.Length);
            }
        }
        static void WriteInt(int value, string path)
        {
            using(FileStream fs = new FileStream(path,FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = BitConverter.GetBytes(value);
                fs.Write(buffer, 0, buffer.Length);
            }
        }

        static string ReadStr(string path)
        {
            string value = String.Empty;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                value = Encoding.Unicode.GetString(buffer);
            }

            return value;
        }
        static void WriteIntFS(int value, FileStream fs)
        {
            var buffer = BitConverter.GetBytes(value);
            fs.Write(buffer, 0, buffer.Length);
        }
        static int ReadIntFS(FileStream fs)
        {
            int value = 0;
            byte[] buffer = new byte[sizeof(int)];
            fs.Read(buffer, 0, buffer.Length);
            value = BitConverter.ToInt32(buffer, 0);
            return value;
        }
        static int ReadInt(string path)
        {
            int value = 0;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[sizeof(int)];
                fs.Read(buffer, 0, buffer.Length);
                value = BitConverter.ToInt32(buffer, 0);
            }
            return value;
        }
        static void Main(string[] args)
        {
            //string fname = "number.dat";
            //Console.OutputEncoding= Encoding.UTF8;
            ////Console.InputEncoding= Encoding.UTF8;
            //string fname = "string.dat";
            ////WriteStr("Hello/Привіт", fname);
            //Console.WriteLine($"Result :: {ReadStr(fname)}");


            /*using(FileStream fs = new FileStream("number.dat",FileMode.Create, FileAccess.Write))
            {
                int[] arr = { 10, -6, 5, 2, 17, -22 };
                foreach (var item in arr)
                {
                    WriteIntFS(item, fs);
                }
            }*/


            using (FileStream fs = new FileStream("number.dat", FileMode.Open, FileAccess.Read))
            {
                int[] arr = new int[(int)(fs.Length / sizeof(int))];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = ReadIntFS(fs);
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
