namespace zadnie2
{
    internal class Program
    {
        static void ProcessFile(string filePath)
        {
            Queue<char> nonDigits = new Queue<char>();
            Queue<char> digits = new Queue<char>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                int ch;
                while ((ch = reader.Read()) != -1)
                {
                    char character = (char)ch;
                    if (char.IsDigit(character))
                        digits.Enqueue(character);
                    else
                        nonDigits.Enqueue(character);
                }
            }

            Console.WriteLine("Результат:");

            foreach (char c in nonDigits)
                Console.Write(c);

            foreach (char c in digits)
                Console.Write(c);

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string filePath = "input.txt";
            ProcessFile(filePath);
        }
    }
}
