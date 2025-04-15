using System.Net.Http.Headers;

namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B (B > A)");
            int b = int.Parse(Console.ReadLine());

            if (1 <= a && a < b && b <= 10)
            {
                int product = 1;
                int num = a;

                while (num <= b)
                {
                    product *= num;
                    num++;
                }

                Console.WriteLine($"Произведение чисел от {a} до {b} = {product}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Убедитесь, что 1 <= A < B <= 10.");
            }
        }
    }
}
