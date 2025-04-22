namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 3)
            {
                Console.WriteLine("В предложении должно быть как минимум 3 слова.");
                return;
            }

            Console.WriteLine("\nИсходное предложение:");
            Console.WriteLine(input);

            string[] swappedWords = (string[])words.Clone();
            string temp = swappedWords[0];
            swappedWords[0] = swappedWords[swappedWords.Length - 1];
            swappedWords[swappedWords.Length - 1] = temp;
            Console.WriteLine("\n1. Первое и последнее слова поменяны местами:");
            Console.WriteLine(string.Join(" ", swappedWords));

            string glued = words[1] + words[2];
            Console.WriteLine("\n2. Второе и третье слова склеены:");
            Console.WriteLine(glued);

            char[] reversed = words[2].ToCharArray();
            Array.Reverse(reversed);
            Console.WriteLine("\n3. Третье слово в обратном порядке:");
            Console.WriteLine(new string(reversed));

            string firstWordCut = words[0].Length > 2 ? words[0].Substring(2) : "";
            Console.WriteLine("\n4. Первое слово без первых двух букв:");
            Console.WriteLine(firstWordCut);
        }
    }
}
