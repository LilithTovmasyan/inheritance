using System;

namespace Inheritance
{
    public class Triangle : Shape
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triangle(double side1, double side2, double side3)
            : base("Triangle")
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;

            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        public override double Perimeter()
        {
            return _side1 + _side2 + _side3;
        }
    }
}
