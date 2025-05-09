/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Анализирует оценки студентов, определяет отличников и вычисляет средние баллы по предметам.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к файлу с оценками студентов.
        /// </summary>
        string marksFile = "mark.txt";

        /// <summary>
        /// Путь к файлу с названиями предметов.
        /// </summary>
        string subjectsFile = "Subjects.txt";

        /// <summary>
        /// Путь к выходному файлу с упорядоченными средними баллами студентов.
        /// </summary>
        string outputFile = "averages.txt";

        /// <summary>
        /// Чтение данных об оценках студентов.
        /// </summary>
        var studentsData = File.ReadAllLines(marksFile)
                               .Select(line => line.Split(' '))
                               .Select(parts => new {
                                   Name = parts[0],
                                   Marks = parts.Skip(1).Select(int.Parse).ToArray()
                               })
                               .ToList();

        /// <summary>
        /// Чтение списка предметов.
        /// </summary>
        var subjects = File.ReadAllLines(subjectsFile);

        /// <summary>
        /// Определение студентов, у которых все оценки не ниже 9.
        /// </summary>
        var topStudents = studentsData.Where(s => s.Marks.All(mark => mark >= 9))
                                      .Select(s => s.Name)
                                      .ToList();

        Console.WriteLine("Отличники:");
        topStudents.ForEach(Console.WriteLine);

        /// <summary>
        /// Вычисление средних баллов по каждому предмету.
        /// </summary>
        var subjectAverages = new Dictionary<string, double>();

        for (int i = 0; i < subjects.Length; i++)
        {
            double average = studentsData.Select(s => s.Marks[i]).Average();
            subjectAverages[subjects[i]] = average;
        }

        Console.WriteLine("\nСредние оценки по предметам:");
        foreach (var entry in subjectAverages)
            Console.WriteLine($"{entry.Key}: {entry.Value:F2}");

        /// <summary>
        /// Вычисление средних баллов студентов и сортировка по убыванию.
        /// </summary>
        var studentAverages = studentsData.Select(s => new {
            Name = s.Name,
            Average = s.Marks.Average()
        })
                                .OrderByDescending(s => s.Average)
                                .ToList();

        /// <summary>
        /// Запись средних баллов студентов в выходной файл.
        /// </summary>
        File.WriteAllLines(outputFile, studentAverages.Select(s => $"{s.Name}: {s.Average:F2}"));

        Console.WriteLine("\nФайл с упорядоченными средними баллами сохранен.");
    }
}
