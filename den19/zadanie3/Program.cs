namespace zadanie3
{
    public interface IPrototype<T>
    {
        T Clone();
    }

    public class Athlete : IPrototype<Athlete>
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Sport { get; set; }

        public Athlete(string name, int? age, string sport)
        {
            Name = name;
            Age = age;
            Sport = sport;
        }

        public Athlete Clone()
        {
            return new Athlete(this.Name, this.Age, this.Sport);
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {(Age.HasValue ? Age.ToString() : "не указан")}, Вид спорта: {Sport}";
        }
    }

    public class AthleteManager
    {
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();

        public void AddAthlete(Athlete athlete)
        {
            Athletes.Add(athlete);
        }

        public void RemoveAthlete(string name)
        {
            Athletes.RemoveAll(a => a.Name == name);
        }

        public List<T> CloneAll<T>(List<T> items) where T : IPrototype<T>
        {
            List<T> clones = new List<T>();
            foreach (T item in items)
            {
                clones.Add(item.Clone());
            }
            return clones;
        }

        public void PrintAll()
        {
            foreach (var a in Athletes)
            {
                Console.WriteLine(a);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AthleteManager manager = new AthleteManager();

            manager.AddAthlete(new Athlete("Иван", 25, "Бокс"));
            manager.AddAthlete(new Athlete("Мария", null, "Плавание"));
            manager.AddAthlete(new Athlete("Анна", 19, "Теннис"));

            Console.WriteLine("Исходный список:");
            manager.PrintAll();

            List<Athlete> копии = manager.CloneAll(manager.Athletes);
            Console.WriteLine("\nКопии:");
            foreach (var a in копии)
                Console.WriteLine(a);

            manager.RemoveAthlete("Мария");

            Console.WriteLine("\nПосле удаления Марии:");
            manager.PrintAll();

            Dictionary<string, Athlete> athleteDict = new Dictionary<string, Athlete>();
            foreach (var a in manager.Athletes)
            {
                athleteDict[a.Name] = a;
            }

            Console.WriteLine("\nДоступ по имени через Dictionary:");
            if (athleteDict.TryGetValue("Иван", out Athlete athlete))
            {
                Console.WriteLine(athlete);
            }
        }
    }
}
