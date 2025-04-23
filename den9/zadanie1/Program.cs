namespace zadanie1
{
    struct TRAIN
    {
        public string Destination;
        public int TrainNumber;
        public TimeSpan DepartureTime;

        public void Display()
        {
            Console.WriteLine($"Пункт назначения: {Destination}, Номер поезда: {TrainNumber}, Время отправления: {DepartureTime}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            const int count = 8;
            TRAIN[] trains = new TRAIN[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nВведите данные для поезда {i + 1}:");
                Console.Write("Пункт назначения: ");
                trains[i].Destination = Console.ReadLine();

                Console.Write("Номер поезда: ");
                trains[i].TrainNumber = int.Parse(Console.ReadLine());

                Console.Write("Время отправления (в формате HH:mm): ");
                trains[i].DepartureTime = TimeSpan.Parse(Console.ReadLine());
            }

            trains = trains.OrderBy(t => t.Destination).ToArray();

            Console.Write("\nВведите время для поиска поездов после него (в формате HH:mm): ");
            TimeSpan userTime = TimeSpan.Parse(Console.ReadLine());

            var result = trains.Where(t => t.DepartureTime > userTime).ToArray();

            Console.WriteLine("\nПоезда, отправляющиеся после указанного времени:");
            if (result.Length == 0)
            {
                Console.WriteLine("Нет поездов, отправляющихся после заданного времени.");
            }
            else
            {
                foreach (var train in result)
                {
                    train.Display();
                }
            }
        }
    }
}
