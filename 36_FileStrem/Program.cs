using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _36_FileStrem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "bytes.dat";
            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
            {
                byte value = 65; // 41 "A"
                byte[] buffer = new byte[] { 10, 11, 12, 13, 14 };

                fs.WriteByte(value);
                fs.Write(buffer, 0, buffer.Length);


                Console.WriteLine($"Position file cursor :: {fs.Position}");
                fs.Seek(0, SeekOrigin.Begin); // перемістили файловий курсо на початок
                                              //fs.Position = 0; // те саме
                Console.WriteLine($"Position file cursor (Begin) :: {fs.Position}");
                /*fs.Seek(-2, SeekOrigin.End);
                Console.WriteLine($"Position file cursor (End) :: {fs.Position}");*/

                byte[] res_arr = new byte[fs.Length];
                fs.Read(res_arr, 0, res_arr.Length);

                Console.WriteLine($"Recover array :: {String.Join<byte>("\t", res_arr)}");
            }
                
            
            //fs.Close();
        }
    }
}
