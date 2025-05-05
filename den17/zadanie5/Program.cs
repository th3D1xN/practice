namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = "f1.dat";
            string file2 = "f2.dat";

            int[] data1 = { -3, 2, -1, 4, -2, 5 }; 
            int[] data2 = { 7, 3, -8, 0, -3, 9, -8, 1 }; 

            File.WriteAllLines(file1, data1.Select(x => x.ToString()));
            File.WriteAllLines(file2, data2.Select(x => x.ToString()));

            int[] f1 = File.ReadAllLines(file1).Select(int.Parse).ToArray();
            int[] f2 = File.ReadAllLines(file2).Select(int.Parse).ToArray();


            int minF2 = f2.Min();
            int closestToMin = f2
                .Where(n => n != minF2)
                .OrderBy(n => Math.Abs(n - minF2))
                .FirstOrDefault();

            Console.WriteLine($"Минимальное значение в f2.dat: {minF2}");
            Console.WriteLine($"Ближайшее к нему по величине: {closestToMin}");

            CountAndCompare(f1, f2);

            bool isSorted = f1.Zip(f1.Skip(1), (a, b) => a <= b).All(x => x);
            Console.WriteLine($"Числа в f1.dat упорядочены по возрастанию: {isSorted}");

            bool isAlternating = true;
            for (int i = 0; i < f1.Length - 1; i++)
            {
                if (f1[i] == 0 || f1[i + 1] == 0 || Math.Sign(f1[i]) == Math.Sign(f1[i + 1]))
                {
                    isAlternating = false;
                    break;
                }
            }
            Console.WriteLine($"f1.dat содержит знакопеременную последовательность: {isAlternating}");
        }

        static void CountAndCompare(int[] f1, int[] f2)
        {
            var stats1 = CountValues(f1);
            var stats2 = CountValues(f2);

            Console.WriteLine("\nСравнение положительных, отрицательных и нулей:");
            Compare("Положительных", stats1.positive, stats2.positive);
            Compare("Отрицательных", stats1.negative, stats2.negative);
            Compare("Нулевых", stats1.zero, stats2.zero);
        }

        static (int positive, int negative, int zero) CountValues(int[] data)
        {
            int positive = data.Count(n => n > 0);
            int negative = data.Count(n => n < 0);
            int zero = data.Count(n => n == 0);
            return (positive, negative, zero);
        }

        static void Compare(string name, int a, int b)
        {
            string result = a > b ? "в f1.dat" : a < b ? "в f2.dat" : "в обоих одинаково";
            Console.WriteLine($"{name}: {result} (f1: {a}, f2: {b})");
        }
    }
}
