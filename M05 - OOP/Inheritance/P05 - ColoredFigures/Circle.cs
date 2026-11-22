using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigures
{
    public class Circle : ColoredFigure
    {
        public Circle(int size, string color)
            : base(size, color)
        {
        }
        public override double GetArea()
        {
            return Math.PI * size * size;
        }
    }
}
