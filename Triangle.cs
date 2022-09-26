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

        public bool IsRightTriangle()
        {
            double hypotenuse;
            double leg1;
            double leg2;
            if (SideA >= SideB && SideA >= SideC)
            {
                hypotenuse = SideA;
                leg1 = SideB;
                leg2 = SideC;
            }
            else if (SideC >= SideB)
            {
                hypotenuse = SideC;
                leg1 = SideA;
                leg2 = SideB;
            }
            else
            {
                hypotenuse = SideB;
                leg1 = SideA;
                leg2 = SideC;
            }

            if (Math.Round(hypotenuse * hypotenuse, 3) == Math.Round((leg1 * leg1 + leg2 * leg2), 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
