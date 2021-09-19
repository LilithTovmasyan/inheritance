using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(10, 15));
            shapes.Add(new Triangle(3,4,5));
            shapes.Add(new Circle(5));

            for (int i = 0; i < shapes.Count; ++i)
            {
                shapes[i].Print();
            }
        }
    }
}
