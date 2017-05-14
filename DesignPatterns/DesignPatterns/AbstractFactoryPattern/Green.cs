using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Green : IColor
    {
        public void fill()
        {
            Console.WriteLine("Inside Green.fill() method.");
        }
    }
}
