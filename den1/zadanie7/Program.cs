namespace zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x (x > 3 или x < -3): ");
            double x = double.Parse(Console.ReadLine());

            if (x <= 3 && x >= -3)
            {
                Console.WriteLine("Ошибка: значение x не входит в область определения формул (x > 3 или x < -3).");
                return;
            }

            double numerator = x * x + 2 * x - 3 + (x + 1) * Math.Sqrt(x * x - 9);
            double denominator = x * x - 2 * x - 3 + (x - 1) * Math.Sqrt(x * x - 9);
            double z1 = numerator / denominator;

            double z2 = Math.Sqrt((x + 3) / (x - 3));

            Console.WriteLine($"Результаты вычислений: z1 = {z1}, z2 = {z2}");

            if (Math.Abs(z1 - z2) < 0.0001) 
            {
                Console.WriteLine("Результаты совпадают!");
            }
            else
            {
                Console.WriteLine("Результаты различаются.");
            }
        }
    }
}
