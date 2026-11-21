using System;
using System.Collections.Generic;
using System.Text;

namespace P02___Figure
{
    public class Square : IDrawable
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }
        public void Draw()
        {
            for (int r = 0; r < this.side; r++)
            {
                Console.WriteLine(new string('*', this.side));
            }
        }
    }
}
