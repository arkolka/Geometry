using System;

namespace Geometry
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            ValidateSides(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        private bool ValidateSides(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Sides can not be less or equal zero");

            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("Side can not be more than or equal to the sum of the other two sides");

            return true;
        }
    }
}
