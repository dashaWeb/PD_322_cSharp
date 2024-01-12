using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_IComparable
{
    class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is Student)
            {
                return LastName.CompareTo(((Student)obj).LastName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public override string ToString()
        {
            return $"FirstName :: {FirstName,-15} LastName :: {LastName,-15} Birthdate :: {Birthdate.ToShortDateString()}";
        }
    }

    class Auditory : IEnumerable
    {
        Student[] students = {
            new Student{
                FirstName = "Candice",
                LastName = "Lemen",
                Birthdate = new DateTime(1998,7,23)
            },
            new Student{
                FirstName = "John",
                LastName = "Miller",
                Birthdate = new DateTime(2000,5,12)
            },
            new Student{
                FirstName = "Joey",
                LastName = "Finch",
                Birthdate = new DateTime(2005,1,1)
            },
            new Student{
                FirstName = "Nicole",
                LastName = "Taylor",
                Birthdate = new DateTime(2002,12,29)
            },
        };
        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
        public override string ToString()
        {
            return $"{String.Join<Student>("\n", students)}";
        }
    }
    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x is Student && y is Student)
            {
                return DateTime.Compare((x as Student).Birthdate, (y as Student).Birthdate);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
