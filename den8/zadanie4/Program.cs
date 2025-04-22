using System.Text.RegularExpressions;

namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string text = "На распродаже были товары по $19.99, €25 и даже $100. Также встречалась цена €9.50";

            string pricePattern = @"[\$€]\d+(?:\.\d{1,2})?";

            MatchCollection matches = Regex.Matches(text, pricePattern);

            Console.WriteLine("Найденные цены:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
