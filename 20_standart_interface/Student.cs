using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_standart_interface
{
    class Student : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private int[] marks;
        public Student(string name = "NoneName", int numMarks = 5)
        {
            Name = name;
            this.marks = new int[numMarks];
        }
        public Student(string name, params int[] marks)
        {
            Name = name;
            this.marks = (int[])marks.Clone();
        }
        public int this[int index]
        {
            get => marks[index];
            set => marks[index] = value > 0 && value <= 12 ? value : throw new ArgumentOutOfRangeException($"Bad value for mark {value}");
        }
        public override string ToString()
        {
            return $"{Name,-5} Marks :: {String.Join<int>(", ",marks)}";
        }
        public object Clone()
        {
            //return new Student(this);
            Student st = new Student(Name, marks);
            return st ;
        }
    }
}
