namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов M: ");
            int M = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];
            Random rand = new Random();

            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11); 
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            Console.Write($"\nВведите номер столбца (от 0 до {M - 1}): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k >= M)
            {
                Console.WriteLine("Ошибка: номер столбца вне допустимого диапазона");
                return;
            }

            Console.Write("Введите число, на кратность которому нужно проверить: ");
            int d = int.Parse(Console.ReadLine());

            if (d == 0)
            {
                Console.WriteLine("Ошибка: нельзя делить на 0");
                return;
            }

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += matrix[i, k];
            }

            Console.WriteLine($"\nСумма элементов столбца {k}: {sum}");

            if (sum % d == 0)
                Console.WriteLine($"Сумма кратна {d}");
            else
                Console.WriteLine($"Сумма не кратна {d}");
        }
    }
}
