using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ColoredFigures
{
    public abstract class ColoredFigure
    {
        string color;
        protected int size;

        public ColoredFigure(int size, string color)
        {
            this.size = size;
            this.color = color;
        }

        public string Show()
        {
           return$"Color: {color}{Environment.NewLine}Size: {size}";
        }

        public string GetName()
        {
            return GetType().Name;
        }

        public abstract double GetArea();

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(GetName());
            builder.AppendLine(Show());
            builder.AppendLine($"Area: {GetArea():f2}");
            return builder.ToString();
        }
    }
}
