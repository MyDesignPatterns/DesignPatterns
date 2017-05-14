using FP = DesignPatterns.FactoryPattern;
using AFP = DesignPatterns.AbstractFactoryPattern;
using SP = DesignPatterns.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryPattern();
            AbstractFactoryPattern();
            SingletonPattern();
            Console.ReadLine();
        }

        /// <summary>
        /// C# Implementation for https://www.tutorialspoint.com/design_pattern/factory_pattern.htm
        /// </summary>
        static void FactoryPattern()
        {
            Console.WriteLine("Start FactoryPattern");
            FP.ShapeFactory shapeFactory = new FP.ShapeFactory();

            //get an object of Circle and call its draw method.
            FP.IShape shape1 = shapeFactory.getShape("CIRCLE");

            //call draw method of Circle
            shape1.draw();

            //get an object of Rectangle and call its draw method.
            FP.IShape shape2 = shapeFactory.getShape("RECTANGLE");

            //call draw method of Rectangle
            shape2.draw();

            //get an object of Square and call its draw method.
            FP.IShape shape3 = shapeFactory.getShape("SQUARE");

            //call draw method of circle
            shape3.draw();
            Console.WriteLine("End FactoryPattern");
        }

        /// <summary>
        /// C# Implementation for https://www.tutorialspoint.com/design_pattern/abstract_factory_pattern.htm
        /// </summary>
        static void AbstractFactoryPattern()
        {
            Console.WriteLine("Start AbstractFactoryPattern");
            //get shape factory
            AFP.AbstractFactory shapeFactory = AFP.FactoryProducer.getFactory("SHAPE");

            //get an object of Shape Circle
            AFP.IShape shape1 = shapeFactory.getShape("CIRCLE");

            //call draw method of Shape Circle
            shape1.draw();

            //get an object of Shape Rectangle
            AFP.IShape shape2 = shapeFactory.getShape("RECTANGLE");

            //call draw method of Shape Rectangle
            shape2.draw();

            //get an object of Shape Square 
            AFP.IShape shape3 = shapeFactory.getShape("SQUARE");

            //call draw method of Shape Square
            shape3.draw();

            //get color factory
            AFP.AbstractFactory colorFactory = AFP.FactoryProducer.getFactory("COLOR");

            //get an object of Color Red
            AFP.IColor color1 = colorFactory.getColor("RED");

            //call fill method of Red
            color1.fill();

            //get an object of Color Green
            AFP.IColor color2 = colorFactory.getColor("Green");

            //call fill method of Green
            color2.fill();

            //get an object of Color Blue
            AFP.IColor color3 = colorFactory.getColor("BLUE");

            //call fill method of Color Blue
            color3.fill();
            Console.WriteLine("End AbstractFactoryPattern");
        }

        /// <summary>
        /// C# Implementation for https://www.tutorialspoint.com/design_pattern/singleton_pattern.htm
        /// </summary>
        static void SingletonPattern()
        {
            Console.WriteLine("Start SingletonPattern");
            //Get the only object available
            SP.SingleObject obj = SP.SingleObject.getInstance();
            //show the message
            obj.showMessage();
            Console.WriteLine("End SingletonPattern");
        }
    }
}
