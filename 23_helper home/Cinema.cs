using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_helper_home
{
    class Cinema : IEnumerable
    {
        Movie[] movies;
        public string Address { get; set; }

        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
        void Sort()
        {
            Array.Sort(movies);
        }
        void Sort(IComparer comparer)
        {
            Array.Sort(movies, comparer);
        }
    }
}
