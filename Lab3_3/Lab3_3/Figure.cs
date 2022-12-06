using System;

namespace Lab3_3
{
    class Figure
    {
        private string name = "";
        public string Name { get { return name; } }
        Point A;
        Point B;
        Point C;
        Point D;
        Point E;
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        public void PerimeterCalculator()
        {
            double perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
            Console.WriteLine($"Perimeter:{perimeter}");
        }
        public Figure(Point A, Point B, Point C)
        {
            name = "Triangle";
            this.A = A;
            this.B = B;
            this.C = C;

        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            name = "Rectangle";
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            name = "Pentagon";
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }
    }
}
