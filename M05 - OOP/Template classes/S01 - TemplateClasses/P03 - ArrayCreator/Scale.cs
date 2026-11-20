using System;
using System.Collections.Generic;
using System.Text;

namespace P03___ArrayCreator
{
    public class Scale<T> where T : IComparable<T>
    {
        T left;
        T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            if (left.CompareTo(right) > 0)
            {
                return left;
            }
            else if (right.CompareTo(left) > 0)
            {
                return right;
            }

            return default(T);
        }
    }

}
