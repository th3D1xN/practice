namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите число b:");
            int b = int.Parse(Console.ReadLine()!);

            int product = a * b;

            Console.WriteLine($"Произведение чисел {a} и {b} = {product}");
        }
    }
}
