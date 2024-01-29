using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Directory_DirectoruInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current path : \n{Directory.GetCurrentDirectory()}");
            Directory.CreateDirectory("A");

            Directory.SetCurrentDirectory("A"); // поточний шлях
            Console.WriteLine($"Current path : \n{Directory.GetCurrentDirectory()}");

            Directory.CreateDirectory("A1");
            Directory.CreateDirectory("A2");

            File.WriteAllText("a.txt", "File a.txt content");
            File.WriteAllText("b.txt", "File b.txt content");

            File.WriteAllText("A1/a1.txt", "File a1.txt content");
            File.WriteAllText("A2/a2.txt", "File a2.txt content");

            // get files from folder A
            //string[] fnames = Directory.GetFiles(".","a*.*"); // 
            string[] fnames = Directory.GetFiles(".","a*.*",SearchOption.AllDirectories); // 
            foreach (var item in fnames)
            {
                Console.WriteLine($"{Path.GetFileName(item)} in folder {Path.GetDirectoryName(item)}");
            }

            string[] dirs = Directory.GetDirectories(".");
            Console.WriteLine($"\n\n List folders from folder A");
            foreach (var item in dirs)
            {
                Console.WriteLine(Path.GetFileName(item));
            }


            string path = @"C:\Users\konopelko\Downloads";
            string[] entries = Directory.GetFileSystemEntries(path);

            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine($"\n\n----- {path}");
            foreach (var item in entries)
            {
                FileInfo fi = new FileInfo(item);
                string info = "<DIR>";
                if(!fi.Attributes.HasFlag(FileAttributes.Directory))
                {
                    info = fi.Length.ToString();
                }
                Console.WriteLine($"{fi.CreationTime,-22} {fi.Name,-50} {info,-15}");
            }

            path = "B";
            DirectoryInfo di = new DirectoryInfo(path);
            if(!di.Exists)
            {
                di.Create();
            }
            Console.WriteLine($"Attributes of B : {di.Attributes}");
            File.WriteAllText("B/b1.txt", "Hello from b1.txt");
            File.WriteAllText("B/b2.txt", "Hello from b2.txt !!! ");
            FileInfo[] list = di.GetFiles();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} :: {item.Length}");
            }
        }
    }
}
