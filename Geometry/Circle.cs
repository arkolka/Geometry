using System;

namespace Geometry
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Radius can not be negative");

                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return (Math.PI * Math.Pow(Radius, 2)) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
