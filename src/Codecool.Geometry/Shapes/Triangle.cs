using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {
        private double _Base;

        private double _SideA;

        private double _SideB;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="base">x</param>
        /// <param name="sideA">x</param>
        /// <param name="sideB">x</param>
        public Triangle(double @base, double sideA, double sideB)
        {
            _Base = @base;
            _SideA = sideA;
            _SideB = sideB;
        }

#pragma warning disable SA1600 // Elements should be documented
        public new string AreaFormula { get { return "square root of: s(s-sideA)(s-sideB)(s-base) where s = (sideA+sideB+base)/2"; } }
#pragma warning restore SA1600 // Elements should be documented

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new string PerimeterFormula { get { return "Base + SideA + SideB"; } }

        /// <inheritdoc/>
        public override double Perimeter { get { return _Base + _SideB + _SideA; } }

        /// <inheritdoc />
        public override double Area { get { return Math.Sqrt((_SideB + _SideA + _Base) / 2 * (((_SideA + _SideB + _Base) / 2) - _SideA) * (((_SideA + _SideB + _Base) / 2) - _SideB) * (((_SideA + _SideB + _Base) / 2) - _Base)); } }
    }
}
