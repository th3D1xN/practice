/// <summary>
/// Пространство имен, содержащее программу Task3.
/// </summary>
namespace task3
{
    /// <summary>
    /// Класс, представляющий двумерный массив.
    /// </summary>
    internal class TwoDimensionalArray
    {
        /// <summary>
        /// Двумерный массив для хранения элементов.
        /// </summary>
        private int[,] array;

        /// <summary>
        /// Конструктор, создающий двумерный массив заданного размера.
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="cols">Количество столбцов.</param>
        public TwoDimensionalArray(int rows, int cols)
        {
            array = new int[rows, cols];
        }

        /// <summary>
        /// Индексатор для доступа к элементам массива.
        /// </summary>
        /// <param name="i">Индекс строки.</param>
        /// <param name="j">Индекс столбца.</param>
        public int this[int i, int j]
        {
            get => array[i, j];
            set => array[i, j] = value;
        }

        /// <summary>
        /// Вычисляет сумму элементов главной диагонали.
        /// </summary>
        /// <returns>Сумма элементов главной диагонали.</returns>
        public int MainDiagonalSum()
        {
            int sum = 0;
            int size = Math.Min(array.GetLength(0), array.GetLength(1));
            for (int i = 0; i < size; i++)
            {
                sum += array[i, i];
            }
            return sum;
        }

        /// <summary>
        /// Оператор сравнения "больше", основанный на сумме главной диагонали.
        /// </summary>
        /// <param name="a">Первый массив.</param>
        /// <param name="b">Второй массив.</param>
        /// <returns>True, если сумма главной диагонали первого массива больше.</returns>
        public static bool operator >(TwoDimensionalArray a, TwoDimensionalArray b)
        {
            return a.MainDiagonalSum() > b.MainDiagonalSum();
        }

        /// <summary>
        /// Оператор сравнения "меньше", основанный на сумме главной диагонали.
        /// </summary>
        /// <param name="a">Первый массив.</param>
        /// <param name="b">Второй массив.</param>
        /// <returns>True, если сумма главной диагонали первого массива меньше.</returns>
        public static bool operator <(TwoDimensionalArray a, TwoDimensionalArray b)
        {
            return a.MainDiagonalSum() < b.MainDiagonalSum();
        }
    }

    /// <summary>
    /// Основной класс программы Task3.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы. Позволяет пользователю вводить массивы и сравнивает их.
        /// </summary>
        static void Main()
        {
            TwoDimensionalArray array1 = new TwoDimensionalArray(3, 3);
            TwoDimensionalArray array2 = new TwoDimensionalArray(3, 3);

            Console.WriteLine("Введите элементы первого массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    array1[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("Введите элементы второго массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    array2[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("\nРезультат сравнения:");
            Console.WriteLine(array1 > array2 ? "Первый массив больше второго." : "Первый массив меньше или равен второму.");
        }
    }
}
