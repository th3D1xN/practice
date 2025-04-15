namespace zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B (B >= A): ");
            int b = int.Parse(Console.ReadLine());

            int num = b;

            while (num >= a)
            {
                Console.WriteLine($"Куб числа {num} = {Math.Pow(num, 3)} (while)");
                num--;
            }

            int i = b;
            do
            {
                Console.WriteLine($"Куб числа {i} = {Math.Pow(i, 3)} (do while)");
                i--;
            } while (i >= a);

            for(int j = b; j >= a; j--)
                Console.WriteLine($"Куб числа {j} = {Math.Pow(j, 3)} (for)");
        }
    }
}