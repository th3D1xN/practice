namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину основания треугольника:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту треугольника:");
            double h = double.Parse(Console.ReadLine());

            double S = a * h / 2;

            Console.WriteLine($"Площадь трегольника = {S}");
            Console.ReadKey();
        }
    }
}
