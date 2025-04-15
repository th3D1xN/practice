using System.Globalization;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Число должно быть трехзначным");
                return;
            }

            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;
            int sumOfDigits = digit1 + digit2 + digit3;

            Console.WriteLine($"Сумма цифр числа {number} = {sumOfDigits}");

            if (sumOfDigits % 2 == 0)
            {
                Console.WriteLine("Высказывание истинно");
            }
            else
            {
                Console.WriteLine("Высказывание не верно");
            }

        }
    }
}