using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _39_StreamWrite_Read
{
    internal class Program
    {
        static void StreamWriteDemo()
        {
            string fname = "data.txt";
            using (StreamWriter sw = new StreamWriter(fname))
            {
                string text = "Test line .... Тестовий рядок";
                int value = 12;
                double valueD = 25.3;
                int[] arr = { 10, 20, 30, 40, 50 };
                sw.WriteLine(text);
                sw.WriteLine(value);
                sw.WriteLine($"Double value  {valueD}");
                foreach (var item in arr)
                {
                    sw.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            //StreamWriteDemo();
            Console.OutputEncoding = Encoding.UTF8;
            string fname = "data.txt";
            Console.WriteLine($"\n\n{new string('*', 40)} Way #1 ReadAllText {new string('*', 40)}");
            Console.WriteLine(File.ReadAllText(fname));


            Console.WriteLine($"\n\n{new string('*', 40)} Way #2 ReadAllLines {new string('*', 40)}");
            var lines = File.ReadAllLines(fname);
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine($"\n\n{new string('*', 40)} Way #3 ReadToEnd {new string('*', 40)}");
            
            using(StreamReader sr = new StreamReader(fname))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            Console.WriteLine($"\n\n{new string('*', 40)} Way #4 ReadLine By Line {new string('*', 40)}");

            using (StreamReader sr = new StreamReader(fname))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line + "--------");
                }
            }

            Console.WriteLine($"\n\n{new string('*', 40)} Way #4 Read Char By Char {new string('*', 40)}");

            using (StreamReader sr = new StreamReader(fname))
            {
                int symbol;
                while ((symbol = sr.Read()) != -1)
                {
                    Console.Write((char)symbol + " *");
                }
                Console.WriteLine();
            }
        }
    }
}
