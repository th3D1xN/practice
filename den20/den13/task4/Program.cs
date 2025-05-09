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
        /// Делегат, генерирующий случайное число.
        /// </summary>
        delegate int RandomDelegate();

        /// <summary>
        /// Главный метод программы. Создает массив делегатов, вычисляет случайные числа и их среднее значение.
        /// </summary>
        static void Main()
        {
            Random rand = new Random();

            /// <summary>
            /// Массив делегатов для генерации случайных чисел.
            /// </summary>
            RandomDelegate[] delegates = new RandomDelegate[5];

            for (int i = 0; i < delegates.Length; i++)
            {
                /// <summary>
                /// Лямбда-выражение для генерации случайного числа от 1 до 100.
                /// </summary>
                delegates[i] = () => rand.Next(1, 101);
            }

            /// <summary>
            /// Анонимный метод для вычисления среднего значения случайных чисел.
            /// </summary>
            /// <param name="delArray">Массив делегатов, генерирующих числа.</param>
            /// <returns>Среднее арифметическое случайных чисел.</returns>
            Func<RandomDelegate[], double> GetAverage = delegate (RandomDelegate[] delArray)
            {
                int sum = 0;

                foreach (var del in delArray)
                {
                    int value = del();
                    Console.WriteLine($"Значение: {value}");
                    sum += value;
                }

                return (double)sum / delArray.Length;
            };

            double average = GetAverage(delegates);
            Console.WriteLine($"Среднее значение: {average:F2}");
        }
    }
}
