using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.OOP.GeometryShapes
{
    internal class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int lenght, int width)
        {
            Length = lenght;
            Width = width;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Площадь прямоугольника: {Length*Width}");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine($"Периметр прямоугольника: {2*(Length+Width)}");
        }

    }
}
