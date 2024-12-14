using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.OOP.GeometryShapes
{
    internal class Triangle : Shape
    {
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
        public int Height{ get; set; }

        public Triangle(int firstSide, int secondSide, int thirdSide, int height)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            Height = height;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Площадь треугольника: {(FirstSide*Height)/2}");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine($"Периметр треугольника: {FirstSide+SecondSide+ThirdSide}");
        }
    }
}
