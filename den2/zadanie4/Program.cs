namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            double y;

            if (x >= 4 && x <= 6)
            {
                y = x;
            }
            else if (x > 6)
            {
                y = 3 * x + 4 * x * x;
            }
            else
            {
                Console.WriteLine("Неверное значение x");
                return;
            }
            Console.WriteLine($"Значение функции y при x = {x} = {y}");
             
        }
    }
}
