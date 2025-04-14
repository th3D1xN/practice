namespace zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            int number = int.Parse(Console.ReadLine());
            if (number < 100 ||  number > 999)
            {
                Console.WriteLine("Число должно быть трехзначным");
                return;
            }

            int firstDigit = number / 100;
            int remainingDigits = number % 100;
            int newNumber = remainingDigits * 10 + firstDigit;

            Console.WriteLine($"Число с переставленной первой цифрой в конец = {newNumber}");
            Console.ReadKey();
        }
    }
}
