namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 25;
            int[] a = new int[size];
            int[] b = new int[size];
            Random rand = new Random();

            Console.WriteLine("Массив a:");
            for (int i = 0; i < size; i++)
            {
                a[i] = rand.Next(-10, 11);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine("\nМассив b (до преобразования):");
            for (int i = 0; i < size; i++)
            {
                b[i] = rand.Next(-10, 11);
                Console.Write(b[i] + " ");
            }

            for (int i = 0; i < size; i++)
            {
                if (a[i] > 0)
                    b[i] *= 10;
                else
                    b[i] = 0;
            }

            Console.WriteLine("\nМассив b (после преобразования):");
            foreach (int value in b)
                Console.Write(value + " ");

            Array.Sort(b);
            Console.WriteLine("\nМассив b (отсортированный):");
            foreach (int value in b)
                Console.Write(value + " ");

            Console.Write("\nВведите число k для поиска: ");
            int k = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(b, k);
            if (index >= 0)
                Console.WriteLine($"Число {k} найдено в массиве на позиции {index}");
            else
                Console.WriteLine($"Число {k} не найдено в массиве");
        }
    }
}
