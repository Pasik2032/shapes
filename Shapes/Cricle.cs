using System;
namespace Shapes
{
    public class Cricle : Shape
    {
        private readonly double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
        }
        public Cricle(double radius)
        {
            this.radius = radius;
        }

        public override double Square() => Math.PI * Math.Pow(radius, 2);
    }
}
