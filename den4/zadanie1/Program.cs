namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите шаг h: ");
                double h = double.Parse(Console.ReadLine());

                Console.WriteLine("\nТаблица значений функции f(x):");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|    x    |        f(x)              |");
                Console.WriteLine("--------------------------------------");

                for (double x = a; x <= b; x += h)
                {
                    double fx = CalculateFunction(x, a, b);
                    Console.WriteLine($"| {x,7:F2} | {fx,23:F6} |");
                }

                Console.WriteLine("--------------------------------------");
            }

            static double CalculateFunction(double x, double a, double b)
            {
                if (2 * x <= -5)
                {
                    return Math.Cos(x * x + x) / a;
                }
                else if (2 * x >= -5 && 2 * x <= 0)
                {
                    return b * x * x - a;
                }
                else 
                {
                    return 5 * x * x + (a * x) / Math.Pow(x, 3); 
                }
            }
        }
    }
}
