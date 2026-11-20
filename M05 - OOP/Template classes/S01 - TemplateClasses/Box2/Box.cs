using System;
using System.Collections.Generic;
using System.Text;

namespace Box2
{
    class Box<T>
    {
		private List<T> data;

		public List<T> Data
		{
			get { return data; }
			set { data = value; }
		}

        public Box()
        {
            Data = new List<T>();
        }

        public void Swap(int index1, int index2)
        {
            var bufferValue = Data[index1];
            Data[index1] = Data[index2];
            Data[index2] = bufferValue;
        }

        public void Add(T item)
        {
            Data.Add(item);
        }


    }
}
