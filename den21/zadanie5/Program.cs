namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 43, 16, 92 };
            bool stopFlag = false;

            Console.WriteLine("Вычисляем сумму и произведение с проверкой прерывания:\n");

            Parallel.ForEach(numbers, (n, state) =>
            {
                if (stopFlag)
                {
                    return;
                }

                long sum = 0;
                long product = 1;

                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                    product *= i;

                    if (sum > 535 || product > 535)
                    {
                        if (!stopFlag)
                        {
                            stopFlag = true;
                            Console.WriteLine($"Прерывание при N = {n} -> сумма = {sum}, произведение = {product}");
                            state.Break();
                        }
                        return;
                    }
                }

                Console.WriteLine($"N = {n}, сумма = {sum}, произведение = {product}");
            });

            Console.WriteLine("\nВычисления завершены.");
        }
    }
}
