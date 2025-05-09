/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Читает числа из файла, подсчитывает количество четных и выводит результат.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к файлу с числами.
        /// </summary>
        string filePath = "g.txt";

        try
        {
            /// <summary>
            /// Чтение чисел из файла и их преобразование в массив.
            /// </summary>
            var numbers = File.ReadAllText(filePath)
                              .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

            /// <summary>
            /// Подсчет количества четных чисел в массиве.
            /// </summary>
            int evenCount = numbers.Count(n => n % 2 == 0);

            Console.WriteLine($"Количество четных чисел: {evenCount}");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка исключений при работе с файлом.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
