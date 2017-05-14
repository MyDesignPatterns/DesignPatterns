using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }

            return null;
        }

        public override IColor getColor(String color)
        {
            return null;
        }
    }
}
