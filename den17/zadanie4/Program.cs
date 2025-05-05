namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string tempFile = "temp.txt";

            if (!File.Exists(file1) || !File.Exists(file2))
            {
                Console.WriteLine("Один из файлов не найден.");
                return;
            }

            string[] lines1 = File.ReadAllLines(file1);
            string[] lines2 = File.ReadAllLines(file2);

            if (lines1.Length != lines2.Length)
            {
                Console.WriteLine("Файлы имеют разное количество строк.");
                return;
            }

            File.WriteAllLines(tempFile, lines1);

            File.WriteAllLines(file1, lines2);

            File.WriteAllLines(file2, File.ReadAllLines(tempFile));

            File.Delete(tempFile);

            Console.WriteLine("Строки файлов успешно обменены.");
        }
    }
}
