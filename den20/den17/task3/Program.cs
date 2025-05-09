/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Создает текстовый файл, записывает строки и определяет длину самой длинной строки.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к текстовому файлу.
        /// </summary>
        string filePath = "textfile.txt";

        /// <summary>
        /// Массив строк для записи в файл.
        /// </summary>
        string[] lines =
        {
            "Первая строка",
            "Вторая строка, она длиннее",
            "Короткая",
            "Очень длинная строка, которая значительно превосходит другие",
            "Средняя длина строки"
        };

        /// <summary>
        /// Запись строк в файл.
        /// </summary>
        File.WriteAllLines(filePath, lines);
        Console.WriteLine($"Файл \"{filePath}\" успешно создан!");

        /// <summary>
        /// Чтение строк из файла и определение длины самой длинной строки.
        /// </summary>
        var fileLines = File.ReadAllLines(filePath);
        int maxLength = fileLines.Max(line => line.Length);
        Console.WriteLine($"Длина самой длинной строки: {maxLength}");
    }
}
