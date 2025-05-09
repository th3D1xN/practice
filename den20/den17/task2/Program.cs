/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Создает папку с указанным именем.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к создаваемой папке.
        /// </summary>
        string folderPath = "New_folder";

        try
        {
            /// <summary>
            /// Создание папки.
            /// </summary>
            Directory.CreateDirectory(folderPath);
            Console.WriteLine($"Папка \"{folderPath}\" успешно создана!");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка исключений при создании папки.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
