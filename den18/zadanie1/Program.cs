using zadanie1Library;

namespace zadanie1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            if (triangle.IsValid())
            {
                Console.WriteLine($"Периметр: {triangle.GetPerimeter()}");
                Console.WriteLine($"Площадь: {triangle.GetArea()}");
                Console.WriteLine($"Тип: {triangle.GetTriangleType()}");
            }
            else
            {
                Console.WriteLine("Такой треугольник не существует.");
            }

            zadanie1Library.Rectangle rectangle = new zadanie1Library.Rectangle(5, 10);
            Console.WriteLine($"Периметр прямоугольника: {rectangle.GetPerimeter()}");
            Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}");
        }
    }
}
