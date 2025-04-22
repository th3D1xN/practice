namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            Console.WriteLine("С какой позиции начинать замену? (нумерация с 0):");
            if (!int.TryParse(Console.ReadLine(), out int startIndex))
            {
                Console.WriteLine("Ошибка: введено не число.");
                return;
            }

            if (startIndex < 0 || startIndex >= input.Length)
            {
                Console.WriteLine("Ошибка: позиция вне диапазона текста.");
                return;
            }

            char[] chars = input.ToCharArray();

            for (int i = startIndex; i < chars.Length; i++)
            {
                if (chars[i] == '?')
                {
                    chars[i] = '!';
                }
            }

            string result = new string(chars);
            Console.WriteLine("Результат:");
            Console.WriteLine(result);  
        }
    }
}
