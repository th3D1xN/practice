namespace zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0.5, B = 1;
            int M = 10;
            double H = (B - A) / M;

            Console.WriteLine("Таблица значений функции arccos(x):");
            for (int i = 0; i <= M; i++)
            {
                double x = A + i * H;
                double y = Math.Acos(x);
                Console.WriteLine($"x = {x:F4}, arccos(x) = {y:F4}");
            }
        }
    }
}
