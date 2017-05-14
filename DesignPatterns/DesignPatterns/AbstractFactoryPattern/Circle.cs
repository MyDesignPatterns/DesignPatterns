using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle.draw() method.");
        }
    }
}
