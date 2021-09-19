namespace Inheritance
{
    public class Rectangle : Shape
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
            : base("Rectangle")
        {
            _height = height;
            _width = width;
        }

        public override double Area()
        {
            return _height * _width;
        }

        public override double Perimeter()
        {
            return 2 * (_height + _width);
        }
    }
}
