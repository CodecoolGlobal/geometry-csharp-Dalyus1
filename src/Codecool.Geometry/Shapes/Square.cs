using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Square implementation class
    /// </summary>
    public class Square : Rectangle
    {
        private double _Length;

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        public Square(double length)
            : base()
        {
            _Length = length;
        }

        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new string AreaFormula { get { return "length*length"; } }

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new string PerimeterFormula { get { return "4*length "; } }

        /// <inheritdoc/>
        ///
        public override double Area
        {
            get { return _Length * _Length; }
        }

        /// <inheritdoc/>
        public override double Perimeter
        {
            get { return 4 * _Length; }
        }
    }
}
