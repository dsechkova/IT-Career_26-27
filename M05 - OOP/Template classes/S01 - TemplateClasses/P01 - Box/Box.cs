using System;
using System.Collections.Generic;
using System.Text;

namespace P01___Box
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
            data.RemoveAt(data.Count-1);
            Count--;
            return element;

        }

        public int Count { get; private set; }
    }
}
