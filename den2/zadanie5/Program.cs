using System.Globalization;

namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int num = int.Parse(Console.ReadLine());

            if (num < 100 || num > 999)
            {
                Console.WriteLine("Число должно быть трехзначным");
                return;
            }

            int digit1 = num / 100;
            int digit2 = (num / 10) % 10;
            int digit3 = (num % 10);

            if (digit1 == digit2 && digit2 == digit3) 
            {
                Console.WriteLine($"Цифры трехзначного числа {num} одинаковы");
            }
            else
            {
                Console.WriteLine($"Цифры трехзначного числа {num} не одинаковы");
            }
        }
    }
}
