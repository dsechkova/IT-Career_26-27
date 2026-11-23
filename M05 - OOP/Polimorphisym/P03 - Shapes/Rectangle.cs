using System;
using System.Collections.Generic;
using System.Text;

namespace P03___Shapes
{
    public class Rectangle: Shape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
           
        }
        public override double CalculatePerimeter()
        {
            double perimeter = this.SideA * 2 + this.SideB * 2;
            return perimeter;
        }
        public override double CalculateArea()
        {
            double area = this.SideA * this.SideB;
            return area;
        }
        public override string Draw()
        {
            string result = base.Draw() + this.GetType().FullName;
            return result;
        }
    
    }
}
