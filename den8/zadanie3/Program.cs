using System.Text.RegularExpressions;

namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "В этом тексте есть числа 3, 7 и 2. Также есть число 10";

            MatchCollection matches = Regex.Matches(text, @"\d+");

            long product = 1;
            foreach (Match match in matches)
            {
                int number = int.Parse(match.Value);
                product *= number;
            }

            Console.WriteLine("Произведение всех чисел в тексте: " + product);
        }
    }
}
