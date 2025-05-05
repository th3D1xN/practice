using System.Threading;
using zadanie2Library;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите вид хлеба:");
                Console.WriteLine("1 - Багет");
                Console.WriteLine("2 - Ржаной хлеб");
                Console.WriteLine("3 - Белый хлеб");
                Console.WriteLine("4 - Батон");
                Console.WriteLine("0 - Выйти");

                Console.Write("\nВаш выбор: ");
                string choice = Console.ReadLine();

                Bread selectedBread = choice switch
                {
                    "1" => new Baguette(),
                    "2" => new RyeBread(),
                    "3" => new WhiteBread(),
                    "4" => new Loaf(),
                    "0" => null,
                    _ => null
                };

                if (selectedBread == null)
                {
                    Console.WriteLine("\nВыход из программы...");
                    break;
                }

                Console.Clear();
                Console.WriteLine("Информация о выбранном хлебе:");
                selectedBread.GetInfo();

                Console.WriteLine("\nНажмите любую клавишу, чтобы выбрать другой хлеб...");
                Console.ReadKey();
            }
        }
    }
}
