namespace Lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(5, 7, "A");
            Point point2 = new Point(8, 6, "B");
            Point point3 = new Point(6, 9, "C");
            Point point4 = new Point(5, 7, "D");
            Point point5 = new Point(8, 6, "E");
            Figure figure = new Figure(point1, point2, point3, point4, point5);
            Console.WriteLine($"Name: {figure.Name}");
            figure.PerimeterCalculator();
        }
    }
}
