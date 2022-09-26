using System;

namespace SquareLibrary
{
    public class Triangle : Figure
    {
        private readonly double SideA;
        private readonly double SideB;
        private readonly double SideC;
        private readonly double p;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            p = (SideA + SideB + SideC) / 2;
        }   

        public override double GetSquare()
        {
            if (CanBeExist())
            {
                return Math.Round(Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)), 3);
            }
            return 0;
        }

        private bool CanBeExist()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                return false;
            }
            else if (SideC >= SideA + SideB)
                return false;
            else if (SideA >= SideB + SideC)
                return false;
            else if (SideB >= SideA + SideC)
                return false;
            else
                return true;
        }
    }
}
