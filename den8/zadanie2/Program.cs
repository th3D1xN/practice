using System.Text.RegularExpressions;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Вот такой вот простой текст про обновление оболочки операционной системы";

            string result = Regex.Replace(text, "[оО]", match => match.Value + "Oк");

            Console.WriteLine("Результат:");
            Console.WriteLine(result);
        }
    }
}
