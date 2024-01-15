using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Generic_class
{
    class Stack<T> : IStack<T>
    {
        private T[] values = new T[0];
        private int top = -1;
        private int capacity = 0;

        public int Capacity { get=>capacity; }
        public int Count { get => top+1; }
        public Stack(int number)
        {
            values = new T[number];
            capacity= number;
        }

        public void Push(T item)
        {
            if(Full())
            {
                capacity *= 2;
                Array.Resize(ref values, capacity);
            }
            values[++top] = item;
        }

        public void Pop()
        {
            if(top >= 0)
            {
                top--;
            }
        }

        public bool Full()
        {
            return top+1 == capacity;
        }

        public T Peek()
        {
           return values[top];
        }
        public override string ToString()
        {
            return String.Join<T>(", ", values);
        }
    }
}
