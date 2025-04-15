namespace zadanie10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            Console.WriteLine($"Делители числа {n}:");
            for (int i = -Math.Abs(n); i <= Math.Abs(n); i++)
            {
                if (i != 0 && n % i == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }

            Console.WriteLine($"\nКоличество делителей: {count}");
        }
    }
}
