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
        /// Делегат для вычисления параметров фигуры.
        /// </summary>
        delegate double CalcFigure(double R);

        /// <summary>
        /// Вычисляет длину окружности по радиусу.
        /// </summary>
        /// <param name="R">Радиус окружности.</param>
        /// <returns>Длина окружности.</returns>
        static double Get_Length(double R)
        {
            return 2 * Math.PI * R;
        }

        /// <summary>
        /// Вычисляет площадь круга по радиусу.
        /// </summary>
        /// <param name="R">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        static double Get_Area(double R)
        {
            return Math.PI * R * R;
        }

        /// <summary>
        /// Вычисляет объем шара по радиусу.
        /// </summary>
        /// <param name="R">Радиус шара.</param>
        /// <returns>Объем шара.</returns>
        static double Get_Volume(double R)
        {
            return (4.0 / 3.0) * Math.PI * R * R * R;
        }

        /// <summary>
        /// Главный метод программы. Выводит вычисленные параметры фигуры.
        /// </summary>
        static void Main()
        {
            double radius = 5.0;

            CalcFigure CF;

            CF = Get_Length;
            Console.WriteLine($"Длина окружности радиуса {radius}: {CF(radius)}");

            CF = Get_Area;
            Console.WriteLine($"Площадь круга радиуса {radius}: {CF(radius)}");

            CF = Get_Volume;
            Console.WriteLine($"Объем шара радиуса {radius}: {CF(radius)}");
        }
    }
}
