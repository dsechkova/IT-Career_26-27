using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Break!";
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{Color} {GetType().Name} {Model}");
            builder.AppendLine(Start());
            builder.AppendLine(Stop());
            return builder.ToString();
        }

    }
}
