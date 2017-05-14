using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IColor getColor(String color);
        public abstract IShape getShape(String shape);
    }
}
