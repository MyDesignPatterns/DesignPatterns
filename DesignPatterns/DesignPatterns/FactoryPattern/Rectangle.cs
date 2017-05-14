using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle.draw() method.");
        }
    }
}
