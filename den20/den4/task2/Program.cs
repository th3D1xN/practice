/// <summary>
/// Пространство имен, содержащее программу Task2.
/// </summary>
namespace task2
{
    /// <summary>
    /// Основной класс программы Task2.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод, переворачивающий цифры в числе.
        /// </summary>
        /// <param name="K">Число, цифры которого будут инвертированы.</param>
        static void InvDigits(ref int K)
        {
            int reversed = 0;
            while (K > 0)
            {
                reversed = reversed * 10 + K % 10;
                K /= 10;
            }
            K = reversed;
        }

        /// <summary>
        /// Главный метод программы. Запрашивает у пользователя пять целых чисел,
        /// переворачивает их и выводит результат.
        /// </summary>
        static void Main()
        {
            /// <summary>
            /// Массив для хранения введенных пользователем чисел.
            /// </summary>
            int[] numbers = new int[5];

            Console.WriteLine("Введите 5 целых положительных чисел:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("\nЧисла с обратным порядком цифр:");
            for (int i = 0; i < 5; i++)
            {
                InvDigits(ref numbers[i]);
                Console.WriteLine($"Число {i + 1}: {numbers[i]}");
            }
        }
    }
}
