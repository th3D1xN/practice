/// <summary>
/// Пространство имен, содержащее программу Task1.
/// </summary>
namespace task1
{
    /// <summary>
    /// Основной класс программы Task1.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Вычисляет значение функции f(x).
        /// </summary>
        /// <param name="x">Значение переменной x.</param>
        /// <param name="a">Параметр a, введенный пользователем.</param>
        /// <param name="b">Параметр b, введенный пользователем.</param>
        /// <returns>Значение функции f(x).</returns>
        static double CalculateFx(double x, double a, double b)
        {
            if (Math.Abs(x) < 1)
            {
                return Math.Tan(b - x);
            }
            else if (Math.Abs(x) >= 1 && Math.Abs(x) <= 5)
            {
                return a / Math.Sqrt(x * x);
            }
            else // Math.Abs(x) > 5
            {
                return 1 / Math.Sqrt(x * x + a + Math.Cos(b * x));
            }
        }

        /// <summary>
        /// Главный метод программы, выполняющий ввод данных и вычисление функции f(x).
        /// </summary>
        static void Main()
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nТаблица значений функции:");
            Console.WriteLine("{0,-10}{1,-10}", "x", "f(x)");
            Console.WriteLine(new string('-', 20));

            for (double x = a; x <= b; x += h)
            {
                try
                {
                    double y = CalculateFx(x, a, b);
                    Console.WriteLine("{0,-10:F2}{1,-10:F2}", x, y);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("{0,-10:F2}{1,-10}", x, "деление на 0!");
                }
            }
        }
    }
}
