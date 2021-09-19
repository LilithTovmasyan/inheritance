using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Shape
    {
        public string _name;

        public Shape(string name)
        {
            _name = name;
        }

        public virtual double Area()
        {
            throw new NotImplementedException();
        }

        public virtual double Perimeter()
        {
            return 0;
        }

        public void Print()
        {
            Console.WriteLine(_name + ":");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }
    }
}
