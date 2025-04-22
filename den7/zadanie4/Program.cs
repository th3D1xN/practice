namespace zadanie4
{
    internal class Program
    {
        static int GetLetterCode(char letter)
        {
            letter = char.ToLower(letter);
            if (letter >= 'а' && letter <= 'я')
            {
                return letter - 'а' + 1;
            }
            return 0;
        }

        static int GetPersonalityCode(int sum)
        {
            while (sum >= 10)
            {
                int tempSum = 0;
                while (sum > 0)
                {
                    tempSum += sum % 10;
                    sum /= 10;
                }
                sum = tempSum;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine()!;

            Console.Write("Введите имя: ");
            string name = Console.ReadLine()!;

            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine()!;

            int totalSum = 0;

            foreach (char c in surname)
            {
                totalSum += GetLetterCode(c);
            }

            foreach (char c in name)
            {
                totalSum += GetLetterCode(c);
            }

            foreach (char c in patronymic)
            {
                totalSum += GetLetterCode(c);
            }

            int personalityCode = GetPersonalityCode(totalSum);

            Console.WriteLine($"Код личности: {personalityCode}");
        }
    }
}
