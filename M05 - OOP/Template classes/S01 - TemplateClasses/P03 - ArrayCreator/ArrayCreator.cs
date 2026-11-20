using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace P03___ArrayCreator
{
    public class ArrayCreator<T>
    {
       public static T[] Create(T item, int length)
        {
            var arr = new T[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = item;
            }
            return arr;
        }
    }
}
