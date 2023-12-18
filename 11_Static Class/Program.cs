using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Static_Class
{
    // static class => 1) може містити лише статичні методи та поля, 2) не можна створити екземпляр
    static class AreaShape
    {
        const double PI = 3.14;
        public static double TrianArea(double height, double side)
        {
            return 0.5 * height * side;
        }
        public static double CircleArea(double radius)
        {
            return PI * Math.Pow(radius,2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //AreaShape area = new AreaShape();
            Console.WriteLine($"Trian Area : {AreaShape.TrianArea(10,20)}");
        }
    }
}
