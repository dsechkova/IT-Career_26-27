using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigures
{
    public class Triangle : ColoredFigure
    {
        public Triangle(int size, string color)
            : base(size, color)
        {
        }

        public override double GetArea()
        {
            return size * size * Math.Sqrt(3) / 4;
        }
    }
}
