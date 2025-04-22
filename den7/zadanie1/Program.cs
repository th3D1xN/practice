namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            string result = "";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    result += '*';
                }
                else
                {
                    result += c;
                }
            }

            Console.WriteLine("Результат:");
            Console.WriteLine(result);
        }
    }
}
