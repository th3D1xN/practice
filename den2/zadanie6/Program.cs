namespace zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый день недели (1-7)");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName = dayNumber switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Число должно быть от 1 до 7"
            };
            Console.WriteLine($"День недели: {dayName}");
        }
    }
}
