namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int A = 5;
                int B = 15;

                Console.WriteLine("Вычисление arccos(x) для x от 5 до 15 с использованием Parallel.For:\n");

                Parallel.For(A, B + 1, x =>
                {
                    if (x >= -1 && x <= 1)
                    {
                        double result = Math.Acos(x);
                        Console.WriteLine($"x = {x}, arccos(x) = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"x = {x} вне области определения функции arccos(x)");
                    }
                });
            }
        }
    }
}
