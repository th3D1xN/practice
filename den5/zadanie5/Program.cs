namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение x: ");
                double x = double.Parse(Console.ReadLine());

                try
                {
                    double denominatorA = 4 * x + 8;
                    if (denominatorA == 0)
                        throw new DivideByZeroException("В выражении (a) деление на 0 невозможно");
                    double y1 = 1 - 4 / denominatorA;
                    Console.WriteLine($"a) y = 1 - 4 / (4x + 8) = {y1:F6}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Ошибка в выражении (a): " + ex.Message);
                }

                try
                {
                    if (x - 1 == 0)
                        throw new DivideByZeroException("В выражении (b) деление на 0 невозможно");
                    double tan = Math.Tan(x);
                    double y2 = tan * tan + 1 / (x - 1);
                    Console.WriteLine($"b) y = tg²(x) + 1 / (x - 1) = {y2:F6}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Ошибка в выражении (b): " + ex.Message);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: нужно ввести корректное число");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
            }
        }
    }
}
