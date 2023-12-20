using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Overload_op
{
    partial class Fraction
    {
        // -,*,/
        public static Fraction operator +(Fraction left, Fraction right) {

            //int num = left.Num * right.Denom + left.Denom * right.Num;
            //int denom = left.Denom * right.Denom;
            //Fraction res = new Fraction(num, denom);
            //return res;
            return new Fraction(left.Num * right.Denom + left.Denom * right.Num, left.Denom * right.Denom);
        }
        // == !=
        public static bool operator ==(Fraction left, Fraction right) {  
            if(ReferenceEquals(left, right)) return true;
            if(left is null || right is null) return false;
            return left.Equals(right); 
        }
        public static bool operator !=(Fraction left, Fraction right)
        {
            return !(left == right);
        }
        public static Fraction operator ++(Fraction left) { // two forms ++ prefix and postfix
            Fraction fraction = new Fraction(1,1);
            return left + fraction;
        }

        // true, false;
        public static bool operator true(Fraction left)
        {
            return left.Num != 0;
        }
        public static bool operator false(Fraction left)
        {
            return left.Num == 0;
        }
        // перетворення типів можна визначити у дві сторони Fraction --> other type, Other type --> Fraction
        public static explicit operator int(Fraction left)
        {
            return left.Num / left.Denom;
        }
        public static implicit operator double(Fraction left)
        {
            return (double)left.Num / left.Denom;
        }
        public static implicit operator Point(Fraction left)
        {
            return new Point(left.Num, left.Denom);
        }
    }
}
