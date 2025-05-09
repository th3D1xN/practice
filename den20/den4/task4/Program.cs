/// <summary>
/// Пространство имен, содержащее программу Task4.
/// </summary>
namespace task4
{
    /// <summary>
    /// Основной класс программы Task4.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод для вычисления минимального значения между двумя числами.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Минимальное из двух чисел.</returns>
        static double Min(double a, double b)
        {
            return a < b ? a : b;
        }

        /// <summary>
        /// Метод для вычисления минимального значения среди трех чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        /// <returns>Минимальное из трех чисел.</returns>
        static double Min(double a, double b, double c)
        {
            return Min(Min(a, b), c);
        }

        /// <summary>
        /// Главный метод программы. Запрашивает у пользователя числа и вычисляет произведение минимальных значений.
        /// </summary>
        static void Main()
        {
            Console.Write("Введите значение a1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение a2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c2: ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double result = Min(a1, b1) * Min(a2, b2, c2);

            Console.WriteLine($"\nРезультат {Min(a1, b1)} * {Min(a2, b2, c2)}: {result:F2}");
        }
    }
}
