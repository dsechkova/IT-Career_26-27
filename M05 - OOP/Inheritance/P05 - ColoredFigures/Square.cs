using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigures
{
    public class Square : ColoredFigure
    {
        public Square(int size, string color)
            : base(size, color)
        {
        }
        public override double GetArea()
        {
            return size * size;
        }
    }
}
