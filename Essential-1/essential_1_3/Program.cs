

using System.Text;

namespace essential_1_3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(0, 4, "B");
            Point point3 = new Point(3, 0, "C");

            Figure figure = new Figure(point1, point2);
            figure.Show();
        }
    }
}
