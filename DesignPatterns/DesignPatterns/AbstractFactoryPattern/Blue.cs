using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Blue : IColor
    {
        public void fill()
        {
            Console.WriteLine("Inside Blue.fill() method.");
        }
    }
}
