using System.Text.RegularExpressions;

namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "В системе были зафиксированы подключения с IP 192.168.1.1, 10.0.0.2 и 172.16.254.3. Также встречается 8.8.8.8";

            string ipPattern = @"\b(?:\d{1,3}\.){3}\d{1,3}\b";

            MatchCollection matches = Regex.Matches(text, ipPattern);

            Console.WriteLine("Найденные IP-адреса:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
