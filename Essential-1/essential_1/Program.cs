
namespace essential_1
{
    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(3.5, 5);
            Console.WriteLine($"Площа прямокнутника {rectangle.Area}");
            Console.WriteLine($"Периметр прямокнутника {rectangle.Perimeter}");
        }
    }
}
