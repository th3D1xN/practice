namespace zadanie3
{
    class Matrix
    {
        private int[,] data;
        private int rows;
        private int cols;
        public int Rows => rows;
        public int Cols => cols;
        public int this[int i, int j]
        {
            get => data[i, j];
            set => data[i, j] = value;
        }

        public Matrix()
        {
            rows = 1;
            cols = 1;
            data = new int[rows, cols];
        }
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];
        }
        public Matrix(Matrix other)
        {
            rows = other.rows;
            cols = other.cols;
            data = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    data[i, j] = other[i, j];
        }
        public void FillFromConsole()
        {
            Console.WriteLine($"Введите элементы матрицы ({rows}x{cols}):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{data[i, j],5}");
                Console.WriteLine();
            }
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.cols != b.rows)
                throw new InvalidOperationException("Матрицы не согласованы для умножения");

            Matrix result = new Matrix(a.rows, b.cols);

            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < b.cols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.cols; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание первой матрицы:");
            Matrix A = new Matrix(2, 3);
            A.FillFromConsole();

            Console.WriteLine("Создание второй матрицы:");
            Matrix B = new Matrix(3, 2);
            B.FillFromConsole();

            Console.WriteLine("\nМатрица A:");
            A.Print();

            Console.WriteLine("\nМатрица B:");
            B.Print();

            try
            {
                Matrix C = A * B;
                Console.WriteLine("\nРезультат умножения A * B:");
                C.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
