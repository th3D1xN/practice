namespace zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "words.txt";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "apple banana radar car level robot door noon");
            }

            string[] words = File.ReadAllText(filePath)
                                .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Введите букву для поиска слов, начинающихся с неё: ");
            char startChar = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            var startWithLetter = words.Where(w => Char.ToLower(w[0]) == startChar);
            Console.WriteLine($"\nСлова, начинающиеся с буквы '{startChar}':");
            foreach (var word in startWithLetter) Console.WriteLine(word);

            Console.Write("\nВведите длину слова для поиска: ");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                var exactLength = words.Where(w => w.Length == length);
                Console.WriteLine($"\nСлова длиной {length} символов:");
                foreach (var word in exactLength) Console.WriteLine(word);
            }

            var sameStartEnd = words.Where(w => Char.ToLower(w[0]) == Char.ToLower(w[^1]));
            Console.WriteLine("\nСлова, начинающиеся и заканчивающиеся одной буквой:");
            foreach (var word in sameStartEnd) Console.WriteLine(word);

            string lastWord = words.Last();
            char lastStartChar = Char.ToLower(lastWord[0]);

            var sameAsLast = words.Where(w => Char.ToLower(w[0]) == lastStartChar);
            Console.WriteLine($"\nСлова, начинающиеся с той же буквы, что и последнее слово \"{lastWord}\":");
            foreach (var word in sameAsLast) Console.WriteLine(word);
        }
    }
}
