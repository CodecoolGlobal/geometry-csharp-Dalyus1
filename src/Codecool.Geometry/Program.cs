using System;
using System.Collections.Generic;
using Codecool.Geometry.Containers;
using Codecool.Geometry.Shapes;

namespace Codecool.Geometry
{
    /// <summary>
    ///     This is the main class of your program which contains Main method
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     This is the entry point of your program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            bool isRunning = true;
            ShapeCollection shapes = new ShapeCollection

            while (isrunning)

            {
                int option = Convert.ToInt32(Console.ReadLine());  // todo read the keyboard here

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please write the desired shape: 1 for rectangle, 2 for square, 3 for triangle or 4 for circle.");
                        int x = Convert.ToInt32(Console.ReadLine());
                        AddShape(x);
                        break;
                    case 2:
                        ShowShapes();
                        break;
                    case 3:
                        Console.WriteLine(LargestParameter());
                        break;
                    case 4:
                        Console.WriteLine(LargestArea());
                        break;
                    case 5:
                        Formulas();
                        break;
                    case 0:
                        break;
                }
            }



            static void Formulas()
            {
                foreach (Shape shape in shapes.Inventory)
                {
                    string areaFormula = shape.AreaFormula;
                    string parameterFormula = shape.ParameterFormula;
                    Console.WriteLine(areaFormula + parameterFormula);
                }
            }

            static double LargestParameter()
            {
                double parameter = 0;
                foreach (Shape shape in shapes.Inventory)
                {
                    if (parameter < shape.Perimeter) parameter = shape.Perimeter;
                }
                return parameter;
            }



            static double LargestArea()
            {
                double area = 0;
                foreach (Shape shape in shapes.Inventory)
                {
                    if (area < shape.Area) area = shape.Area;
                }
                return area;
            }

            static void ShowShapes()
            {
                foreach (Shape shape in Shapes)
                {
                    Console.WriteLine(shape);
                }
            }

            static void AddShape(int x)
            {
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Please add the length:");
                        double len = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please add the width:");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(len, width);
                        shapes.Inventory.Add(rectangle);
                    case 2:
                        Console.WriteLine("Please add the length:");
                        double len = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square(len);
                        shapes.Inventory.Add(square);
                    case 3:
                        Console.WriteLine("Please add the sideB:");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please add the sideA:");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please add the base:");
                        double @base = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(@base, a, b);
                        shapes.Inventoryapes.Add(triangle);
                    case 4:
                        Console.WriteLine("Please add the radius:");
                        double len = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(len);
                        shapes.Inventory.Add(circle);
                }
            }

        }
    }
}
