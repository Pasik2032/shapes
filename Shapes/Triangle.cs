using System;
namespace Shapes
{
    public class Triangle : Shape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public double A
        {
            get
            {
                return a;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (!(a + b > c || a + c > b || b + c > a))
            {
                throw new ArgumentException("It is not possible to create a " +
                    "triangle on these sides.");
            }
            this.a = a;
            this.b = b;
            this.c = c;

        }

        public override double Square()
        {
            double p = (A + B + C) / 2;
 
            return Math.Sqrt(p* (p - A) * (p - B) * (p - C));
        }
    }
}
