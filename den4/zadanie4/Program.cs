namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a1 (> 0): ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите a2: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Введите b2 (должно быть больше a2): ");
            int b2 = int.Parse(Console.ReadLine());

            if (a1 <= 0 || b2 <= a2)
            {
                Console.WriteLine("Ошибка: проверьте вводимые данные.");
                return;
            }

            int sum1 = SumFor(a1);
            int sum2 = SumFor(a2, b2);

            Console.WriteLine($"SumFor({a1}) = {sum1}");
            Console.WriteLine($"SumFor({a2}, {b2}) = {sum2}");
            Console.WriteLine($"Результат: {sum1} * {sum2} = {sum1 * sum2}");
        }

        static int SumFor(int a)
        {
            int sum = 0;
            for (int i = 0; i <= a; i++)
                sum += i;
            return sum;
        }

        static int SumFor(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
                sum += i;
            return sum;
        }
    }
}
