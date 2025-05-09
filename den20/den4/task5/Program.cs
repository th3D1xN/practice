/// <summary>
/// Пространство имен, содержащее программу Task5.
/// </summary>
namespace task5
{
    /// <summary>
    /// Класс, представляющий матрицу с вещественными числами.
    /// </summary>
    class RealMatrix
    {
        /// <summary>
        /// Двумерный массив для хранения значений матрицы.
        /// </summary>
        private double[,] data;

        /// <summary>
        /// Количество строк в матрице.
        /// </summary>
        public int Rows { get; private set; }

        /// <summary>
        /// Количество столбцов в матрице.
        /// </summary>
        public int Columns { get; private set; }

        /// <summary>
        /// Конструктор по умолчанию. Создает матрицу 1x1 с значением 1.
        /// </summary>
        public RealMatrix()
        {
            Rows = 1;
            Columns = 1;
            data = new double[1, 1];
            data[0, 0] = 1.0;
        }

        /// <summary>
        /// Конструктор, создающий матрицу заданного размера.
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="columns">Количество столбцов.</param>
        public RealMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Размеры матрицы должны быть положительными.");

            Rows = rows;
            Columns = columns;
            data = new double[rows, columns];
        }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы.
        /// </summary>
        /// <param name="i">Индекс строки.</param>
        /// <param name="j">Индекс столбца.</param>
        public double this[int i, int j]
        {
            get => data[i, j];
            set => data[i, j] = value;
        }

        /// <summary>
        /// Создает копию текущей матрицы.
        /// </summary>
        /// <returns>Копия матрицы.</returns>
        public RealMatrix Clone()
        {
            RealMatrix result = new RealMatrix(Rows, Columns);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    result[i, j] = data[i, j];
            return result;
        }

        /// <summary>
        /// Метод для вывода матрицы в консоль.
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    Console.Write($"{data[i, j],8:F2} ");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа запущена!");
            // Здесь можно выполнить тестирование матрицы
            RealMatrix matrix = new RealMatrix(2, 2);
            matrix[0, 0] = 1.0;
            matrix[0, 1] = 2.0;
            matrix[1, 0] = 3.0;
            matrix[1, 1] = 4.0;

            Console.WriteLine("Исходная матрица:");
            matrix.Print();
        }
    }
}
