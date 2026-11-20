using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Xml.Linq;

namespace P01___Box
{
    public class CustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
		private List<T> data;

		public List<T> Data
		{
			get { return data; }
			set { data = value; }
		}

        public CustomList()
        {
            Data = new List<T>();
        }

        public void Add(T element)
        {
            Data.Add(element);
        }

        public T Remove(int index)
        {
            var element = Data[index];
            Data.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            if (Data.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            var bufferValue = Data[index1];
            Data[index1] = Data[index2];
            Data[index2] = bufferValue;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;
            for (int i = 0; i < Data.Count; i++)
            {
                if (element.CompareTo(Data[i]) < 0)
                {
                    count++;
                }
            }
            return count;   
        }

        public T Max()
        {
            T element = Data[0];
            for (int i = 0; i < Data.Count; i++)
            {
                if (element.CompareTo(Data[i]) < 0)
                {
                    element = Data[i];
                }
            }
            return element;
        }

        public T Min()
        {
            T element = Data[0];
            for (int i = 0; i < Data.Count; i++)
            {
                if (element.CompareTo(Data[i]) > 0)
                {
                    element = Data[i];
                }
            }
            return element;
        }

        public void Print()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)Data).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Data).GetEnumerator();
        }
    }
}
