namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 123;

            Task<int> task1 = Task.Run(() =>
            {
                if (number < 100 || number > 999)
                    throw new ArgumentException("Число должно быть трёхзначным");

                int firstDigit = number / 100;
                int lastTwoDigits = number % 100;
                int result = lastTwoDigits * 10 + firstDigit;

                return result;
            });

            Task task2 = task1.ContinueWith(prevTask =>
            {
                Console.WriteLine($"Результат преобразования числа {number} -> {prevTask.Result}");
            });

            Task.WaitAll(task1, task2);
        }
    }
}
