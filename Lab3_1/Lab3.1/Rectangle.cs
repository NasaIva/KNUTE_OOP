using System;

namespace Lab3_1
{
    class Rectangle
    {
        private double side1 = 0;
        private double side2 = 0;
        private double area = 0;
        private double perimeter = 0;
        public double Area
        {
            get { return area; }
        }
        public double Perimeter
        {
            get { return perimeter; }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            double areacal = side1 * side2;
            area = areacal;
            return areacal;
        }
        public double PerimeterCalculator()
        {
            double perimetercal = (side1 + side2) * 2;
            perimeter = perimetercal;
            return perimetercal;
        }

    }
}