using SmartDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Inheritance
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new TV { Name = "TV", Memory = 1024, Diagonal = 1280, Weight = 10, Brand = "LG" };
            Console.WriteLine(device);

            Device[] devices = new Device[] {
                device,
                new SmartTV {Name = "SmartTV", Brand = "LG", Effect3D = true, Weight = 15, Diagonal = 2800, Memory = 2048 },
                new SmartPhone {Name = "SmartPhone", Memory = 32, Brand = "Samsung", Phone = "---------"}
            };
            foreach (var item in devices)
            {
                Console.WriteLine("\n==============================\n");
                Console.WriteLine(item);
            }

            Console.WriteLine("\n==============================\n");
            TV[] tv_items = new TV[]
            {
                new TV{Name = "TV"},
                new SmartTV {Name = "SmartTV", Brand = "LG", Effect3D = true, Weight = 15, Diagonal = 2800, Memory = 2048 },
            };
            foreach (var item in tv_items)
            {
                Console.WriteLine("\n==============================\n");
                Console.WriteLine(item);
            }

        }
    }
}
