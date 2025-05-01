namespace zadanie2
{
    public delegate double MathFunction(double x);
    internal class Program
    {
        public static double Square(double x)
        {
            return x * x;
        }

        public static double Cube(double x)
        {
            return x * x * x;
        }

        public static double Sine(double x)
        {
            return Math.Sin(x);
        }

        public static void ExecuteFunction(MathFunction func, double x)
        {
            try
            {
                double result = func(x);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выполнении функции: {ex.Message}");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                double input = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Квадрат:");
                ExecuteFunction(Square, input);

                Console.WriteLine("Куб:");
                ExecuteFunction(Cube, input);

                Console.WriteLine("Синус:");
                ExecuteFunction(Sine, input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }
        }
    }
}
