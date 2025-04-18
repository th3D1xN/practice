namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное число K (целое положительное): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите цифру D1 (от 0 до 9): ");
            int d1 = int.Parse(Console.ReadLine());
            Console.Write("Введите цифру D2 (от 0 до 9): ");
            int d2 = int.Parse(Console.ReadLine());

            AddRightDigit(d1, ref k);
            Console.WriteLine($"После добавления D1 = {d1}, K = {k}");

            AddRightDigit(d2, ref k);
            Console.WriteLine($"После добавления D2 = {d2}, K = {k}");
        }

        static void AddRightDigit(int D, ref int K)
        {
            if (D < 0 || D > 9)
            {
                Console.WriteLine("Ошибка: D должна быть цифрой от 0 до 9.");
                return;
            }

            K = K * 10 + D;
        }
    }
}
