namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "New_folder";

            Directory.CreateDirectory(folderPath);

            Console.WriteLine($"Папка \"{folderPath}\" создана (или уже существует).");
        }
    }
}
