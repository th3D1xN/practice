/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Создает два файла с числами, анализирует данные и выводит результаты.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к первому файлу.
        /// </summary>
        string file1 = "f1.dat";

        /// <summary>
        /// Путь ко второму файлу.
        /// </summary>
        string file2 = "f2.dat";

        GenerateFile(file1, 10);
        GenerateFile(file2, 10);

        Console.WriteLine($"Файлы \"{file1}\" и \"{file2}\" созданы.\n");

        /// <summary>
        /// Чтение чисел из второго файла и поиск минимального числа.
        /// </summary>
        var numbers2 = ReadNumbersFromFile(file2);
        int minNumber = numbers2.Min();
        int closestToMin = numbers2.Where(n => n != minNumber).OrderBy(n => Math.Abs(n - minNumber)).FirstOrDefault();

        Console.WriteLine($"Минимальное число в \"{file2}\": {minNumber}");
        Console.WriteLine($"Ближайшее к нему число: {closestToMin}\n");

        AnalyzeNumbers(file1);
        AnalyzeNumbers(file2);

        /// <summary>
        /// Проверка, отсортированы ли числа в первом файле.
        /// </summary>
        var numbers1 = ReadNumbersFromFile(file1);
        bool isSorted = numbers1.SequenceEqual(numbers1.OrderBy(n => n));
        Console.WriteLine($"\nЧисла в \"{file1}\" упорядочены по возрастанию: {isSorted}");

        /// <summary>
        /// Проверка, образуют ли числа знакопеременную последовательность.
        /// </summary>
        bool isAlternating = numbers1.Zip(numbers1.Skip(1), (a, b) => a * b < 0).All(x => x);
        Console.WriteLine($"Числа в \"{file1}\" образуют знакопеременную последовательность: {isAlternating}");
    }

    /// <summary>
    /// Генерирует файл с заданным количеством случайных чисел.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    /// <param name="count">Количество чисел.</param>
    static void GenerateFile(string filePath, int count)
    {
        Random rnd = new Random();
        var numbers = Enumerable.Range(0, count).Select(_ => rnd.Next(-50, 50)).ToArray();
        File.WriteAllLines(filePath, numbers.Select(n => n.ToString()));
    }

    /// <summary>
    /// Читает числа из файла и возвращает их в виде массива.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    /// <returns>Массив чисел.</returns>
    static int[] ReadNumbersFromFile(string filePath)
    {
        return File.ReadAllLines(filePath).Select(int.Parse).ToArray();
    }

    /// <summary>
    /// Анализирует числа в файле, выводя количество положительных, отрицательных и нулей.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    static void AnalyzeNumbers(string filePath)
    {
        var numbers = ReadNumbersFromFile(filePath);
        int positiveCount = numbers.Count(n => n > 0);
        int negativeCount = numbers.Count(n => n < 0);
        int zeroCount = numbers.Count(n => n == 0);

        Console.WriteLine($"Файл \"{filePath}\" содержит:");
        Console.WriteLine($"Положительных чисел: {positiveCount}");
        Console.WriteLine($"Отрицательных чисел: {negativeCount}");
        Console.WriteLine($"Нулей: {zeroCount}");
    }
}
