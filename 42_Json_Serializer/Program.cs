using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
//using Newtonsoft.Json;
using System.IO;
using System.Net;
namespace _42_Json_Serializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car car = new Car(122,"Ford",2.5);
            Car car2 = new Car(311,"BMW",2.9);
            string fname = "car.json";*/

            /*string json = JsonConvert.SerializeObject(car);
            Console.WriteLine(json);
            File.WriteAllText(fname, json);*/

            /*string rJson = File.ReadAllText(fname);
            Car rCar = JsonConvert.DeserializeObject<Car>(rJson);
            Console.WriteLine(rCar);*/

            /*List<Car> carList = new List<Car>() { car,car2};
            var json = JsonConvert.SerializeObject(carList);
            File.WriteAllText(fname,json);*/

            /*List<Car> list = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(fname));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }*/
           /*  Dictionary<int, Car> cars = new Dictionary<int, Car>()
             {
                 [car.id] = car,
                 [car2.id] = car2,
             };*/
            /*var json = JsonConvert.SerializeObject(cars);
            Console.WriteLine(json);
            File.WriteAllText(fname, json);*/

            /*var rDict = JsonConvert.DeserializeObject<IDictionary<int, Car>>(File.ReadAllText(fname));
            foreach (var kvp in rDict)
            {
                Console.WriteLine(kvp.Value);
            }*/
            /*string json = JsonSerializer.Serialize<Car>(car); // only property!!!!
            Console.WriteLine(json);
            Car res = JsonSerializer.Deserialize<Car>(json);
            Console.WriteLine(res);

            json = JsonSerializer.Serialize<Dictionary<int,Car>>(cars);
            Console.WriteLine(json);
            Dictionary<int, Car> listCars = JsonSerializer.Deserialize<Dictionary<int, Car>>(json);
            foreach (var item in listCars)
            {
                Console.WriteLine(item.Value);
            }*/
           WebClient client = new WebClient();
            var json = client.DownloadString("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=11");
            Console.WriteLine(json);
        }
    }
}
