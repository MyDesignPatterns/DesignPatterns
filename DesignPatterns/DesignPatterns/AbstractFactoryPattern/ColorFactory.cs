using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public override IShape getShape(String shapeType)
        {
            return null;
        }

        public override IColor getColor(String color)
        {
            if (color == null)
            {
                return null;
            }

            if (color.Equals("RED", StringComparison.OrdinalIgnoreCase))
            {
                return new Red();

            }
            else if (color.Equals("GREEN", StringComparison.OrdinalIgnoreCase))
            {
                return new Green();

            }
            else if (color.Equals("BLUE", StringComparison.OrdinalIgnoreCase))
            {
                return new Blue();
            }

            return null;
        }
    }
}
