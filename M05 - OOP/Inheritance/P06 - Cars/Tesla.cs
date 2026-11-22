using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Battery { get; private set; }
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
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
            builder.AppendLine($"{Color} {GetType().Name} {Model} with {Battery} Batteries");
            builder.AppendLine(Start());
            builder.AppendLine(Stop());
            return builder.ToString();
        }

    }
}
