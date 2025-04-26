namespace task4
{
    internal class Program
    {
        delegate int RandomDelegate();

        static void Main()
        {
            Random rand = new Random();

            RandomDelegate[] delegates = new RandomDelegate[5];

            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => rand.Next(1, 101); 
            }

            Func<RandomDelegate[], double> GetAverage = delegate (RandomDelegate[] delArray)
            {
                int sum = 0;

                foreach (var del in delArray)
                {
                    int value = del();
                    Console.WriteLine($"Значение: {value}");
                    sum += value;
                }

                return (double)sum / delArray.Length;
            };

            double average = GetAverage(delegates);
            Console.WriteLine($"Среднее значение: {average:F2}");
        }
    }

}
