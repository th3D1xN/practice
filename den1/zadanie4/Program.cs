namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату c: ");
            int c = int.Parse(Console.ReadLine());

            int x = -(b / (2 * a));
            int y = (a * x * x) + (b * x) + c;

            Console.WriteLine($"Координаты вершины параболы: x = {x}, y = {y}");
        }
    }
}
