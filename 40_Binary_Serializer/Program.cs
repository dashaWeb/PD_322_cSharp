using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _40_Binary_Serializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100,"Ford",2.3);
            Car car2 = new Car(200,"BMW",2.9);
            Console.WriteLine(car);
            string fname = "car.dat";

            BinaryFormatter bf = new BinaryFormatter();
            /*using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                bf.Serialize(fs, car);
            }
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                Car rCar = (Car)bf.Deserialize(fs);
                Console.WriteLine($"Recovered car : {rCar}");
            }*/

            Dictionary<int, Car> salon = new Dictionary<int, Car>
            {
                [100] = car,
                [200] = car2,
            };
            string fnameSalon = "carsalon.dat";
            using (FileStream fs = new FileStream(fnameSalon, FileMode.Create))
            {
                bf.Serialize(fs, salon);

                fs.Position = 0;
                Dictionary<int,Car> salonR = (Dictionary<int, Car>)bf.Deserialize(fs);
                Console.WriteLine("\n\n Recovered car salon");
                foreach (var item in salonR)
                {
                    Console.WriteLine($"{item.Key} \t {item.Value}");
                }
            }
        }
    }
}
