
namespace essential_1_3
{
    class Figure
    {
        Point[] points;
        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                Console.WriteLine("Фігура повинна мати від 3 до 5 точок");
            }
            this.points = points;
        }
        //public Figure(Point point1, Point point2, Point point3) 
        //{
        //    points = new Point[] { point1, point2,point3 };
        //}
        //public Figure(Point point1, Point point2, Point point3, Point point4)
        //{
        //    points = new Point[] { point1, point2, point3,point4 };
        //}
        //public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        //{
        //    points = new Point[] { point1, point2, point3, point4, point5 };
        //}
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        public double PerimetrCalculator()
        {
            if (points.Length < 3)
            {
                return 0;
            }
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length;
                perimeter += LengthSide(points[i], points[nextIndex]);
            }

            return perimeter;
        }
        public void Show()
        {
            Console.Write("назва багатокнутника - ");

            foreach (Point point in points) 
            {
                Console.Write(" "+point.Str);
            }
            Console.WriteLine();
            Console.Write($"периметр багатокнутника - {PerimetrCalculator()}");
        }
    }
}
