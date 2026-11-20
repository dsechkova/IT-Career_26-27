using System;
using System.Collections.Generic;
using System.Text;

namespace P02___BoxOfEverything
{
    public class Box<T>
    {


        private List<T> data;

        public List<T> Data
        {
            get { return data; }
            set { data = value; }
        }


        public Box()
        {
            data = new List<T>();
            Count = 0;
        }

        public void Add(T element)
        {
            data.Add(element);
            Count++;
        }

        public T Remove()
        {
            T element = data.Last();
            data.Remove(element);
            Count--;
            return element;

        }

        public int Count { get; private set; }
    }
}
