using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Red : IColor
    {
        public void fill()
        {
            Console.WriteLine("Inside Red.fill() method.");
        }
    }
}
