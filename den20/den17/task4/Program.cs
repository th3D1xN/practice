/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Читает строки из файла, разделяет их на четные и нечетные, затем записывает в отдельные файлы.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к входному файлу.
        /// </summary>
        string inputFile = "input.txt";

        /// <summary>
        /// Путь к файлу, содержащему четные строки.
        /// </summary>
        string evenLinesFile = "even_lines.txt";

        /// <summary>
        /// Путь к файлу, содержащему нечетные строки.
        /// </summary>
        string oddLinesFile = "odd_lines.txt";

        try
        {
            /// <summary>
            /// Чтение всех строк из входного файла.
            /// </summary>
            var lines = File.ReadAllLines(inputFile);

            /// <summary>
            /// Фильтрация четных строк (индексы 1, 3, 5...).
            /// </summary>
            var evenLines = lines.Where((line, index) => index % 2 == 1).ToArray();

            /// <summary>
            /// Фильтрация нечетных строк (индексы 0, 2, 4...).
            /// </summary>
            var oddLines = lines.Where((line, index) => index % 2 == 0).ToArray();

            /// <summary>
            /// Запись четных строк в отдельный файл.
            /// </summary>
            File.WriteAllLines(evenLinesFile, evenLines);

            /// <summary>
            /// Запись нечетных строк в отдельный файл.
            /// </summary>
            File.WriteAllLines(oddLinesFile, oddLines);

            Console.WriteLine($"Четные строки записаны в \"{evenLinesFile}\"");
            Console.WriteLine($"Нечетные строки записаны в \"{oddLinesFile}\"");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка ошибок при работе с файлами.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
