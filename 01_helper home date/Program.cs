using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_helper_home_date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str_date = Console.ReadLine();
            int day, month, year;
            var res = str_date.Split('.');
            day = int.Parse(res[0]);
            month = int.Parse(res[1]);
            year = int.Parse(res[2]);
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
            }
            var name_day = new DateTime(year, month, day);
            Console.WriteLine(name_day.DayOfWeek);
        }
    }
}
