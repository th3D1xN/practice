namespace zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B (B > A): ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); 

            int N = b - a + 1;
            Console.WriteLine("Количество чисел: " + N);
        }
    }
}
