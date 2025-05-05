namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";

            string[] lines = {
            "Apple is tasty",
            "Banana is yellow",
            "Avocado is green",
            "Blueberry pie",
            "Apricot jam"
        };
            File.WriteAllLines(filePath, lines);

            Console.Write("Введите начальную букву: ");
            char startChar = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            string[] fileLines = File.ReadAllLines(filePath);

            var matchingLines = fileLines
                .Where(line => line.Length > 0 && Char.ToLower(line[0]) == startChar);

            Console.WriteLine($"\nСтроки, начинающиеся с буквы '{startChar}':");
            foreach (var line in matchingLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
