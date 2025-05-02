namespace zadanie3
{
    internal class Program
    {
        static int A, N;
        static readonly object multiplicationLock = new object();
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());

            Thread t1 = new Thread(PerformAddition);
            Thread t2 = new Thread(PerformAddition);

            Thread t3 = new Thread(PerformMultiplication);
            Thread t4 = new Thread(PerformMultiplication);

            t1.Start("Сложение Поток 1");
            t2.Start("Сложение Поток 2");
            t3.Start("Умножение Поток 1");
            t4.Start("Умножение Поток 2");

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();

            Console.WriteLine("Все потоки завершены.");
        }
        static void PerformAddition(object threadName)
        {
            int result = A;
            for (int i = 1; i <= N; i++)
            {
                result += i;
                Thread.Sleep(30);
            }
            Console.WriteLine($"{threadName}: результат сложения = {result}");
        }

        static void PerformMultiplication(object threadName)
        {
            lock (multiplicationLock)
            {
                int result = A;
                for (int i = 1; i <= N; i++)
                {
                    result *= i;
                    Thread.Sleep(30);
                }
                Console.WriteLine($"{threadName}: результат умножения = {result}");
            }
        }
    }
}
