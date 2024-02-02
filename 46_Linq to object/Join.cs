using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Linq_to_object
{

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
    }
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class TestJoin
    {
        public static void Way1()
        {
            List<Group> groups = new List<Group>()
            {
                new Group(){ Id = 1, Name = "BD322"},
                new Group(){ Id = 2, Name = "BV321"},
            };
            List<Student> students = new List<Student>() {
                new Student(){ FirstName = "John", LastName = "Miller", GroupId = 2 },
                new Student(){ FirstName = "Alex", LastName = "Leman", GroupId = 1 },
                new Student(){ FirstName = "Joey", LastName = "Finch", GroupId = 1 },
                new Student(){ FirstName = "Nicole", LastName = "Taylor", GroupId = 3 },
            };
            var query = from g in groups
                        join st in students on g.Id equals st.GroupId
                        select new { FirstName = st.FirstName, LastName = st.LastName, GroupName = g.Name };
            Console.WriteLine("Students in group");
            foreach (var item in query)
            {
                Console.WriteLine($"Surname : {item.LastName}, Name : {item.FirstName}, Group : {item.GroupName}");
            }
            Console.WriteLine();

            var res = groups.Join(students,
                                    g => g.Id,
                                    st => st.GroupId,
                                    (g, st) => new { FirstName = st.FirstName, LastName = st.LastName, GroupName = g.Name });
            Console.WriteLine("Students in group");
            foreach (var item in query)
            {
                Console.WriteLine($"Surname : {item.LastName}, Name : {item.FirstName}, Group : {item.GroupName}");
            }
            Console.WriteLine();
        }
    }
}
