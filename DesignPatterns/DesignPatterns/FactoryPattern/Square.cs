using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square.draw() method.");
        }
    }
}
