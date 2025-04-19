namespace zadanie6
{
    class Program
    {
        public class OutOfRangeException : Exception
        {
            public OutOfRangeException(string message) : base(message) { }
        }

        static void Main()
        {
            try
            {
                Console.Write("Введите значение x: ");
                string input = Console.ReadLine();
                double x = double.Parse(input);

                double f = CalculateFunction(x);
                Console.WriteLine($"f(x) = {f}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат ввода");
            }
            catch (OutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка диапазона: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Другая ошибка: {ex.Message}");
            }
        }

        static double CalculateFunction(double x)
        {
            if (x <= 0)
            {
                throw new OutOfRangeException("Значение x должно быть больше 0");
            }
            else if (x < 1)
            {
                return x - 4;
            }
            else
            {
                double denominator = 2 * x - 2;
                if (denominator == 0)
                    throw new DivideByZeroException();

                return x / denominator;
            }
        }
    }
}