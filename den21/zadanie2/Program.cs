namespace zadanie2
{
    class TaskCalc
    {
        public double X { get; set; }

        public TaskCalc(double x)
        {
            X = x;
        }

        public double CalculateZ1()
        {
            Thread.Sleep(2000);
            double underRoot = X * X - 9;
            if (underRoot < 0) throw new Exception("Подкоренное выражение отрицательно");
            double sqrt = Math.Sqrt(underRoot);

            double numerator = X * X + 2 * X - 3 + (X + 1) * sqrt;
            double denominator = X * X - 2 * X - 3 + (X - 1) * sqrt;

            if (denominator == 0) throw new DivideByZeroException("Деление на ноль");
            return numerator / denominator;
        }

        public double CalculateZ2()
        {
            Thread.Sleep(3000);
            if (X - 3 == 0) throw new DivideByZeroException("Деление на ноль");
            double value = (X + 3) / (X - 3);
            if (value < 0) throw new Exception("Подкоренное выражение отрицательно");
            return Math.Sqrt(value);
        }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            double x = 5;

            TaskCalc obj1 = new TaskCalc(x);
            TaskCalc obj2 = new TaskCalc(x);

            Task<double> task1 = Task.Run(() => obj1.CalculateZ1());
            Task<double> task2 = Task.Run(() => obj2.CalculateZ2());

            Console.WriteLine("Ожидаем завершения хотя бы одной задачи:");
            Task firstFinished = await Task.WhenAny(task1, task2);
            Console.WriteLine($"Первая завершённая задача вернула: {((Task<double>)firstFinished).Result}");

            Console.WriteLine("Ожидаем завершения всех задач:");
            await Task.WhenAll(task1, task2);

            Console.WriteLine($"z1 = {task1.Result}");
            Console.WriteLine($"z2 = {task2.Result}");
        }
    }
}
