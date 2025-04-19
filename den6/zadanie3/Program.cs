namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы N (N < 10): ");
            int N = int.Parse(Console.ReadLine());

            if (N >= 10 || N <= 0)
            {
                Console.WriteLine("Ошибка: N должно быть от 1 до 9");
                return;
            }

            Console.Write("Введите значение a (нижняя граница диапазона): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b (верхняя граница диапазона): ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Ошибка: a должно быть меньше или равно b");
                return;
            }

            int[,] matrix = new int[N, N];
            Random rand = new Random();

            Console.WriteLine("\nИсходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(a, b + 1);
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            long product = 1;
            bool hasOdd = false;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        product *= matrix[i, j];
                        hasOdd = true;
                    }
                }
            }

            if (hasOdd)
                Console.WriteLine($"\nПроизведение нечётных элементов: {product}");
            else
                Console.WriteLine("\nВ матрице нет нечётных элементов");

            Console.Write($"\nВведите номер строки k (от 0 до {N - 1}): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k >= N)
            {
                Console.WriteLine("Ошибка: номер строки вне допустимого диапазона");
                return;
            }

            int rowSum = 0;
            for (int j = 0; j < N; j++)
            {
                rowSum += matrix[k, j];
            }

            Console.WriteLine($"Сумма элементов {k}-й строки: {rowSum}");
        }
    }
}
