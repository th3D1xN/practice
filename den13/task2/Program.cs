namespace task2
{
    internal class Program
    {
        static void Main()
        {
            Func<double, double, double> Add = (a, b) => a + b;
            Func<double, double, double> Sub = (a, b) => a - b;
            Func<double, double, double> Mul = (a, b) => a * b;
            Func<double, double, double> Div = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                    return double.NaN;
                }
                return a / b;
            };

            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию (+, -, *, /):");
            string op = Console.ReadLine()!;

            double result = 0;
            bool valid = true;

            switch (op)
            {
                case "+":
                    result = Add(num1, num2);
                    break;
                case "-":
                    result = Sub(num1, num2);
                    break;
                case "*":
                    result = Mul(num1, num2);
                    break;
                case "/":
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Неизвестная операция.");
                    valid = false;
                    break;
            }

            if (valid)
            {
                Console.WriteLine($"Результат: {result}");
            }
        }
    }

}
