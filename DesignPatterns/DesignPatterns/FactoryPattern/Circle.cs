using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle.draw() method.");
        }
    }
}
