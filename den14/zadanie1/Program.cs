namespace zadanie1
{
    public delegate double MathFunction(double x);
    internal class Program
    {
         public static double Square(double x)
        {
            return x * x;
        }

        public static double Cube(double x)
        {
            return x * x * x;
        }

        public static double Sine(double x)
        {
            return Math.Sin(x);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                double input = Convert.ToDouble(Console.ReadLine());

                MathFunction mathDelegate;

                mathDelegate = Square;
                Console.WriteLine($"Квадрат: {mathDelegate(input)}");

                mathDelegate = Cube;
                Console.WriteLine($"Куб: {mathDelegate(input)}");

                mathDelegate = Sine;
                Console.WriteLine($"Синус: {mathDelegate(input)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
