namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "numbers.txt";

            Console.WriteLine("Введите числа через пробел:");
            string input = Console.ReadLine();
            File.WriteAllText(filePath, input);

            string fileContent = File.ReadAllText(filePath);
            int[] numbers = fileContent
                            .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            int min = numbers.Min();

            int positiveCount = numbers.Count(n => n > 0);

            Console.WriteLine($"Минимальное число: {min}");
            Console.WriteLine($"Количество положительных чисел: {positiveCount}");
        }
    }
}
