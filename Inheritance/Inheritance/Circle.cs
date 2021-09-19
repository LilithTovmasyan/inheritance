using System;

namespace Inheritance
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
            : base("Circle")
        {
            _radius = radius;
        }

        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }

    }
}
