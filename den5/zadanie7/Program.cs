namespace zadanie7
{
    class Program
    {
        public class NegativeOrZeroException : Exception
        {
            public NegativeOrZeroException(string message) : base(message) { }
        }

        static void Main()
        {
            Console.WriteLine("Введите 5 положительных целых чисел:");

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write($"Число {i + 1}: ");
                    string input = Console.ReadLine();
                    int number = int.Parse(input);

                    if (number <= 0)
                    {
                        throw new NegativeOrZeroException("Число должно быть положительным и больше нуля");
                    }

                    if (number == 10)
                    {
                        int test = number / (number - 10); 
                    }

                    InvertDigits(ref number);
                    Console.WriteLine($"Инвертированное число: {number}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введён некорректный формат числа");
                    i--; 
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль");
                    i--; 
                }
                catch (NegativeOrZeroException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    i--; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
                    i--; 
                }
            }
        }

        static void InvertDigits(ref int K)
        {
            int reversed = 0;
            int original = K;

            while (K > 0)
            {
                reversed = reversed * 10 + K % 10;
                K /= 10;
            }

            K = reversed;
        }
    }
}
