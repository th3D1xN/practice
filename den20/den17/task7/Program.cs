/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Создает новый каталог, копирует файлы, скрывает их и создает ссылки.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Диск, на котором создается каталог.
        /// </summary>
        string targetDrive = "C:\\";

        /// <summary>
        /// Путь к новому каталогу.
        /// </summary>
        string newDirectory = Path.Combine(targetDrive, "Exmple_38tp");

        /// <summary>
        /// Путь к исходной папке с файлами для копирования.
        /// </summary>
        string sourceDirectory = "С:\\done";

        /// <summary>
        /// Получение списка первых трех файлов для копирования.
        /// </summary>
        string[] filesToCopy = Directory.GetFiles(sourceDirectory).Take(3).ToArray();

        /// <summary>
        /// Создание нового каталога.
        /// </summary>
        Directory.CreateDirectory(newDirectory);
        Console.WriteLine($"Каталог \"{newDirectory}\" создан.");

        /// <summary>
        /// Копирование файлов, скрытие их и создание ссылок.
        /// </summary>
        foreach (var file in filesToCopy)
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(newDirectory, fileName);

            File.Copy(file, destFile, true);
            File.SetAttributes(destFile, FileAttributes.Hidden);
            Console.WriteLine($"Файл \"{fileName}\" скопирован и скрыт.");

            /// <summary>
            /// Создание текстовой ссылки на файл.
            /// </summary>
            string shortcutPath = Path.Combine(newDirectory, fileName + ".lnk");
            using (StreamWriter writer = new StreamWriter(shortcutPath))
            {
                writer.WriteLine($"Ссылка на файл: {file}");
            }
            Console.WriteLine($"Создана ссылка \"{shortcutPath}\".");
        }

        /// <summary>
        /// Вывод списка всех файлов на доступных локальных дисках.
        /// </summary>
        Console.WriteLine("\nСписок всех файлов на локальном диске:");
        foreach (var drive in DriveInfo.GetDrives())
        {
            if (drive.IsReady)
            {
                Console.WriteLine($"Файлы на диске {drive.Name}:");

                foreach (var file in Directory.GetFiles(drive.Name, "*.*", SearchOption.AllDirectories))
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
