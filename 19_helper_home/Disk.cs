using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_helper_home
{
    class Disk : IDisk
    {
        protected string memory;
        protected int memSize;
        public string Memory { get; set; }
        public int MemSize { get; set; }
        public string Read()
        {
            return $"Name :: {memory} \t MemSize :: {memSize}";
        }

        public Disk()
        {}
        public Disk(string memory, int memSize)
        {
            Memory= memory;
            MemSize= memSize;
        }
        public void Write(string text)
        {
            Console.WriteLine($"Method Write --> {text}"); 
        }
        string GetName()
        {
            return Memory;
        }
    }
}
