using System;

namespace SquareLibrary
{
    public class Circle : Figure
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            if (Radius <= 0)
            {
                return 0;
            }
            return Math.Round((Math.PI * Radius * Radius), 3);
        }
    }
}
