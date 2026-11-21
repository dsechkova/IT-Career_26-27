using System;
using System.Collections.Generic;
using System.Text;

namespace P01___Stack
{
    public class StackOfStrings 
    {
        private List<string> data;

        public StackOfStrings()
        {
            data = new List<string>();
        }

        public void Push(string element)
        {
            data.Add(element);
        }

        public string Pop()
        {
            int lastIndex = data.Count - 1;
            string element = data[lastIndex];
            data.RemoveAt(lastIndex);
            return element;
        }

        public string Peek()
        {
            string element = data.Last();
            return element;
        }

        public bool IsEmpty()
        {
            if (data.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
