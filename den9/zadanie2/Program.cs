namespace zadanie2
{
    internal class Program
    {
        enum Post
        {
            Manager = 160,
            Developer = 180,
            Designer = 170,
            Tester = 165
        }

        class Accountant
        {
            public bool AskForBonus(Post worker, int hoursWorked)
            {
                int requiredHours = (int)worker;

                return hoursWorked > requiredHours;
            }
        }
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();

            (Post worker, int hoursWorked)[] employees = new (Post, int)[]
            {
                (Post.Manager, 170),
                (Post.Developer, 175),
                (Post.Designer, 180),
                (Post.Tester, 160)
            };

            foreach (var employee in employees)
            {
                bool bonus = accountant.AskForBonus(employee.worker, employee.hoursWorked);
                Console.WriteLine($"Сотруднику {employee.worker} с отработанными {employee.hoursWorked} часами премия: {(bonus ? "Положена" : "Не положена")}");
            }

        }
    }
}
