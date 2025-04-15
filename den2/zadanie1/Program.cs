namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата: ");
            int a = int.Parse(Console.ReadLine());

            int perimeter = 4 * a;

            Console.WriteLine($"Периметр квадрата со стороной {a} = {perimeter}");
        }
    }
}
