using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice)
        {
            if (choice.Equals("SHAPE", StringComparison.OrdinalIgnoreCase))
            {
                return new ShapeFactory();

            }
            else if (choice.Equals("COLOR", StringComparison.OrdinalIgnoreCase))
            {
                return new ColorFactory();
            }

            return null;
        }
    }
}
