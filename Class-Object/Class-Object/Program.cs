using System;

namespace Class_Object
{
    class Shapes
    {
        public double length;
        public double width;
        public double radius;
        public double pie;

        private double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = w * l;
            return Area;
        }
        public double CalCircleArea(double r, double p)
        {
            radius = r;
            pie = p;
            double total = r * p;
            return total;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            double CircArea = 3 * 3;
            double Pie = 3.14;

            Shapes Rectangle = new Shapes();
            Shapes Squares = new Shapes();
            Shapes Circle = new Shapes();

            Console.WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));
            Console.WriteLine("Area of Square is: " + Squares.CalArea(SqWidth, SqWidth));
            Console.WriteLine("Area of Circle is: " + Circle.CalCircleArea(CircArea, Pie));
        }
    }
}
