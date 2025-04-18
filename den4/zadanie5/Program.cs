namespace zadanie5
{
    class RealMatrix
    {
        private double[,] data;
        private int rows;
        private int cols;

        public int Rows => rows;
        public int Cols => cols;

        public double this[int i, int j]
        {
            get => data[i, j];
            set => data[i, j] = value;
        }

        public RealMatrix()
        {
            rows = 1;
            cols = 1;
            data = new double[1, 1];
        }

        public RealMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new double[rows, cols];
        }

        public void FillFromConsole()
        {
            Console.WriteLine($"Введите элементы матрицы ({rows}x{cols}):");
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    data[i, j] = double.Parse(Console.ReadLine());
                }
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{data[i, j],8:F2}");
                Console.WriteLine();
            }
        }

        public bool IsSquare() => rows == cols;

        public bool IsZero()
        {
            foreach (var item in data)
                if (item != 0) return false;
            return true;
        }

        public bool IsIdentity()
        {
            if (!IsSquare()) return false;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    if (i == j && data[i, j] != 1) return false;
                    if (i != j && data[i, j] != 0) return false;
                }
            return true;
        }

        public bool IsDiagonal()
        {
            if (!IsSquare()) return false;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (i != j && data[i, j] != 0) return false;
            return true;
        }

        public bool IsSymmetric()
        {
            if (!IsSquare()) return false;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (data[i, j] != data[j, i]) return false;
            return true;
        }

        public bool IsUpperTriangular()
        {
            if (!IsSquare()) return false;
            for (int i = 1; i < rows; i++)
                for (int j = 0; j < i; j++)
                    if (data[i, j] != 0) return false;
            return true;
        }

        public bool IsLowerTriangular()
        {
            if (!IsSquare()) return false;
            for (int i = 0; i < rows; i++)
                for (int j = i + 1; j < cols; j++)
                    if (data[i, j] != 0) return false;
            return true;
        }

        public static bool operator ==(RealMatrix a, RealMatrix b)
        {
            if (a.rows != b.rows || a.cols != b.cols)
                return false;

            for (int i = 0; i < a.rows; i++)
                for (int j = 0; j < a.cols; j++)
                    if (a[i, j] != b[i, j]) return false;

            return true;
        }

        public static bool operator !=(RealMatrix a, RealMatrix b) => !(a == b);

        public override bool Equals(object obj)
        {
            if (obj is RealMatrix other)
                return this == other;
            return false;
        }

        public override int GetHashCode() => data.GetHashCode();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RealMatrix matrix = new RealMatrix(3, 3);
            matrix.FillFromConsole();

            Console.WriteLine("\nВведённая матрица:");
            matrix.Print();

            Console.WriteLine("\nПроверки:");
            Console.WriteLine($"Квадратная: {matrix.IsSquare()}");
            Console.WriteLine($"Нулевая: {matrix.IsZero()}");
            Console.WriteLine($"Единичная: {matrix.IsIdentity()}");
            Console.WriteLine($"Диагональная: {matrix.IsDiagonal()}");
            Console.WriteLine($"Симметричная: {matrix.IsSymmetric()}");
            Console.WriteLine($"Верхняя треугольная: {matrix.IsUpperTriangular()}");
            Console.WriteLine($"Нижняя треугольная: {matrix.IsLowerTriangular()}");

            Console.WriteLine("\nСоздание второй матрицы для сравнения:");
            RealMatrix matrix2 = new RealMatrix(3, 3);
            matrix2.FillFromConsole();

            Console.WriteLine($"Равны ли матрицы: {matrix == matrix2}");
            Console.WriteLine($"Не равны ли матрицы: {matrix != matrix2}");
        }
    }
}
