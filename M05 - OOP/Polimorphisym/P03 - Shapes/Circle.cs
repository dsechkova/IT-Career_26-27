using System;
using System.Collections.Generic;
using System.Text;

namespace P03___Shapes
{
    public class Circle : Shape
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double CalculatePerimeter()
        {
            double result = 2 * Math.PI * this.Radius;
            return result;
        }
        public override double CalculateArea()
        {
            double result = Math.PI * this.Radius * this.Radius;
            return result;
        }

        public override string Draw()
        {
            string result = base.Draw() + this.GetType().FullName;
            return result;
        }

    }
}
