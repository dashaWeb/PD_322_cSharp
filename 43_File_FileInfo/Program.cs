using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_File_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First line", "Second Line" };
            string fname = "my.txt";

            File.SetAttributes(fname, FileAttributes.Archive);

            if (File.Exists(fname))
            {
                File.Delete(fname);
                Console.WriteLine($"File '{fname}' was deleted\n\n");
            }
            File.AppendAllLines(fname, lines);
            File.AppendAllText(fname, "Third line\nFourth line");

            Console.WriteLine($"Content of file \n\n{File.ReadAllText(fname)}");

            string fname2 = "../../copy_my.txt";
            //File.Copy(fname, fname2);// exception якщо файл вже існує fname2
            File.Copy(fname, fname2,true); // дозвіл на перезапис у файл копію fname2
            Console.WriteLine($"\nContent of copy file '{fname2}' \n{File.ReadAllText(fname2)}");


            /*var fs = File.Create(fname);
            fs.WriteByte(65);*/
            //var fs = File.AppendText(fname);
            var fs = File.CreateText(fname);
            fs.WriteLine("Write something .... 2");
            fs.Close();

            File.AppendAllText(fname, "New line");
            Console.WriteLine($"Content of file (after append) '{fname}' \n{File.ReadAllText(fname)}");

            Console.WriteLine($"Creation time {File.GetCreationTime(fname)}");
            Console.WriteLine($"Last write time {File.GetLastWriteTime(fname)}");

            string fname3 = "../../third.txt";
            FileInfo fi = new FileInfo(fname3);

            Console.WriteLine($"\n\n Is exists file '{fname3}' :: {fi.Exists}");
            if(!fi.Exists)
            {
                using(var tw = fi.CreateText())
                {
                    tw.WriteLine("It is third file");
                }
            }

            Console.WriteLine($"Content of file '{fname3}' \n{File.ReadAllText(fname3)}");

            //fi.MoveTo("./third.txt"); // поточна папка, зараз це папка .../bin/debug
            //Console.WriteLine($"Move to path : {Path.Combine(".",fname3)}"); // bad example
            //Console.WriteLine($"Move to path : {Path.Combine(".",fi.Name)}"); 
            //fi.MoveTo(Path.Combine(".", fi.Name)); // поточна папка, зараз це папка .../bin/debug

            Console.WriteLine($"Length of '{fname3}' :: {fi.Length}");
            Console.WriteLine($"Extension of '{fname3}' :: {fi.Extension}");
            Console.WriteLine($"File attributes of '{fname3}' :: {File.GetAttributes(fname3)}");

            File.SetAttributes(fname3, FileAttributes.ReadOnly);
            Console.WriteLine($"File attributes of '{fname3}' :: {File.GetAttributes(fname3)}");
        }
    }
}
