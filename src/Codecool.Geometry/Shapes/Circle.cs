using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : Shape
    {
        private double _Radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">ceva</param>
        public Circle(double radius)
        {
            _Radius = radius;
        }

        /// <summary>
        ///     Gets formula for the area of the circle as a string.
        /// </summary>
        public new string AreaFormula { get { return "Radius * 3,14"; } }

    /// <summary>
    ///     Gets formula for the perimeter of the circle as a string.
    /// </summary>
        public new string PerimeterFormula { get { return "2 * 3,14 * Radius"; } }

        /// <inheritdoc />
        public override double Area { get { return 2 * 3.14 * _Radius; } }

        /// <inheritdoc />
        public override double Perimeter { get { return 2 * 3.14 * _Radius; } }
    }
}
