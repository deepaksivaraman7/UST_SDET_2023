using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle:Shape,IDrawable
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle\nArea: {0}\nPerimeter: {1}", CalculateArea(), CalculatePerimeter());
        }
    }
}
