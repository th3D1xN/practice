using System.Diagnostics;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(CalculateSum);
            Thread t2 = new Thread(CalculateSum);

            t1.Start("Поток 1");
            t2.Start("Поток 2");

            t1.Join();
            t2.Join();

            Console.WriteLine("Все потоки завершены.");
        }
        static void CalculateSum(object threadName)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Thread.Sleep(50);
            }

            sw.Stop();
            Console.WriteLine($"{threadName}: сумма = {sum}, время выполнения = {sw.ElapsedMilliseconds} мс");
        }
    }
}
