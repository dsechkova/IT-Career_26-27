using System;
using System.Collections.Generic;
using System.Text;

namespace P05___EvenNumbers
{
    internal class EvenNumber
    {
  
		private int num;

        public EvenNumber(int num)
        {
            Num = num;
        }

        public int Num
		{
			get { return num; }
			set { num = value; }
		}

        public override string ToString()
        {
            return $"{Num}";
        }

    }
}
