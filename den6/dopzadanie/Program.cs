namespace dopzadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[,] spiral = new int[n, n];

            int value = 1;
            int top = 0, bottom = n - 1;
            int left = 0, right = n - 1;

            while (value <= n * n)
            {
                for (int i = left; i <= right; i++)
                    spiral[top, i] = value++;
                top++;

                for (int i = top; i <= bottom; i++)
                    spiral[i, right] = value++;
                right--;

                for (int i = right; i >= left; i--)
                    spiral[bottom, i] = value++;
                bottom--;

                for (int i = bottom; i >= top; i--)
                    spiral[i, left] = value++;
                left++;
            }

            Console.WriteLine("Массив 7x7, заполненный по спирали:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(spiral[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }
        }
    }
}
