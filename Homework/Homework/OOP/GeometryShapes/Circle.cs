using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework.OOP.GeometryShapes
{
    internal class Circle : Shape
    {
        public double pi = Math.PI;
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Площадь окружности: {pi*(Radius*Radius)}");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine($"Периметр окружности: {pi*2*Radius}");
        }
    }
}
