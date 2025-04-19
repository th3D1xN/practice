namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("Введите два числа");

                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine(a + "/" + b + " = " + a / b);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Нужно ввести число");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Делить на нуль нельзя");
                }
                catch
                {
                    Console.WriteLine("Какая-то ошибка");
                }
                finally
                {
                    Console.WriteLine("после try-блока");
                }
            }
        }
    }
}
//Ввод  Исключение  Результат
//4, 2  — | Деление успешно
//3, g  FormatException  Нужно ввести число
//d, 1  FormatException  Нужно ввести число
//2, 0  DivideByZeroException  Делить на нуль нельзя
//123456789987654321, 1  OverflowException  Какая-то ошибка