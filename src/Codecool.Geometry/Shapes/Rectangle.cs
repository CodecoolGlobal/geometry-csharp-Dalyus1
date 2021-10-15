using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Rectangle implementation class
    /// </summary>
    public class Rectangle : Shape
    {
        private double _Width;

        private double _Length;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="length">deimmensions needed to work</param>
        /// <param name="width">deimmensions needed to work</param>
        public Rectangle(double length, double width)
        {
            _Width = width;
            _Length = length;
        }

        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new string AreaFormula { get { return "width * length "; } }

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new string PerimeterFormula { get { return "2*width + 2*length "; } }

        /// <inheritdoc />
        public override double Area
        {
            get { return _Width * _Length; }
        }

        /// <inheritdoc/>
        public override double Perimeter
        {
            get { return (2 * _Width) + (2 * _Length); }
        }
    }
}
