using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_helper_home
{
    enum Genre
    {
        Comedy, Horror
    }
    class Movie : ICloneable, IComparable
    {
        public string Title { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public short Rating { get; set; }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            if(obj is Movie)
            {
                return Title.CompareTo(((Movie)obj).Title);
            }
            throw new NotImplementedException();
        }
    }
    class YearComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Movie && y is Movie)
            {
                return (x as Movie).Year.CompareTo((y as Movie).Year);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    class RatingComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Movie && y is Movie)
            {
                return (x as Movie).Rating.CompareTo((y as Movie).Rating);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
