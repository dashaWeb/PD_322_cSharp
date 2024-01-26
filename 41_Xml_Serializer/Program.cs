using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _41_Xml_Serializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "car.xml";
            Car car = new Car(22, "Toyota", 2.3);
            Car car2 = new Car(300, "Pegout", 2.7);

            XmlSerializer xs = new XmlSerializer(typeof(Car));

            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                xs.Serialize(fs, car);

                fs.Position = 0;

                Car recCar = xs.Deserialize(fs) as Car;
                Console.WriteLine($"Recovered car : {recCar}");
            }

            string fnameCars = "listCar.xml";
            List<Car> cars = new List<Car>()
            { car,
              car2
            };

            XmlSerializer xsL = new XmlSerializer(typeof(List<Car>));
            using(TextWriter tw =  new StreamWriter(fnameCars))
            {
                xsL.Serialize(tw, cars);
            }
            using(TextReader tr = new StreamReader(fnameCars))
            {
                /*List<Car>*/ var listCar = xsL.Deserialize(tr) as List<Car>;
                Console.WriteLine($"\n\n Recovered list of csr \n{String.Join<Car>("\n",listCar)}");
            }
        }
    }
}
