namespace zadanie1
{
    public class Task
    {
        private int number;

        public Task(int number)
        {
            if (number < 100 || number > 999)
                throw new ArgumentException("Число должно быть трёхзначным.");
            this.number = number;
        }

        public int CalculateProduct()
        {
            int a = number / 100;
            int b = (number / 10) % 10;
            int c = number % 10;
            return a * b * c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(123);
            Console.WriteLine("Вариант 1: " + task1.CalculateProduct());

            Console.WriteLine("Вариант 2: " + new Task(321).CalculateProduct());

            Console.Write("Введите трёхзначное число: ");
            int userNumber;
            if (int.TryParse(Console.ReadLine(), out userNumber) && userNumber >= 100 && userNumber <= 999)
            {
                Task task3 = new Task(userNumber);
                Console.WriteLine("Вариант 3: " + task3.CalculateProduct());
            }
            else
            {
                Console.WriteLine("Ошибка: нужно ввести трёхзначное число.");
            }
        }
    }
}
