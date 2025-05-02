namespace zadanie4
{
    internal class Program
    {
        static int[] numbers;
        static int[] partialSums;
        static int threadCount;
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество потоков: ");
            threadCount = int.Parse(Console.ReadLine());

            numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i;
            }

            partialSums = new int[threadCount];
            Thread[] threads = new Thread[threadCount];

            int chunkSize = n / threadCount;

            for (int i = 0; i < threadCount; i++)
            {
                int threadIndex = i; 
                threads[i] = new Thread(() => ProcessChunk(threadIndex, chunkSize));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            int totalSum = 0;
            for (int i = 0; i < threadCount; i++)
            {
                totalSum += partialSums[i];
            }

            Console.WriteLine($"Сумма четных чисел: {totalSum}");
        }
        static void ProcessChunk(int threadIndex, int chunkSize)
        {
            int start = threadIndex * chunkSize;
            int end = (threadIndex == threadCount - 1) ? numbers.Length : start + chunkSize;

            int localSum = 0;
            for (int i = start; i < end; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    localSum += numbers[i];
                }
            }

            partialSums[threadIndex] = localSum;
            Console.WriteLine($"Поток {threadIndex + 1}: сумма = {localSum}");
        }
    }
}
