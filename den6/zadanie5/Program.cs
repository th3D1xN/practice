namespace zadanie5
{
    internal class Program
    {
        static long Factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Ошибка: n должно быть положительным числом.");
                return;
            }

            long fact_n_minus_1 = Factorial(n - 1);
            long fact_n = Factorial(n);

            double f = (double)fact_n_minus_1 / fact_n;

            Console.WriteLine($"f({n}) = ({n - 1})! / {n}! = {f}");
        }
    }
}
