namespace zadanie3
{
    using System;

    class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int year, int month, int day)
        {
            SetDate(year, month, day);
        }

        public void SetDate(int year, int month, int day)
        {
            if (IsValidDate(year, month, day))
            {
                this.year = year;
                this.month = month;
                this.day = day;
            }
            else
            {
                throw new ArgumentException("Недопустимая дата");
            }
        }

        private bool IsValidDate(int year, int month, int day)
        {
            return year > 0 && month >= 1 && month <= 12 && day >= 1 && day <= DateTime.DaysInMonth(year, month);
        }

        public void ChangeYear(int years)
        {
            SetDate(year + years, month, day);
        }

        public void ChangeMonth(int months)
        {
            int newYear = year + months / 12;
            int newMonth = (month + months) % 12;
            if (newMonth == 0)
            {
                newMonth = 12;
                newYear--;
            }
            SetDate(newYear, newMonth, day);
        }

        public void ChangeDay(int days)
        {
            DateTime newDate = new DateTime(year, month, day).AddDays(days);
            SetDate(newDate.Year, newDate.Month, newDate.Day);
        }

        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите дату (год, месяц, день):");
            int year = GetInput("Год: ");
            int month = GetInput("Месяц: ");
            int day = GetInput("День: ");

            try
            {
                Date date = new Date(year, month, day);
                Console.WriteLine("Созданная дата: " + date);

                Console.WriteLine("\nВведите количество дней, месяцев и лет для изменения:");
                int days = GetInput("Дней: ");
                int months = GetInput("Месяцев: ");
                int years = GetInput("Лет: ");

                date.ChangeDay(days);
                Console.WriteLine($"Дата после добавления {days} дней: {date}");

                date.ChangeMonth(months);
                Console.WriteLine($"Дата после добавления {months} месяцев: {date}");

                date.ChangeYear(years);
                Console.WriteLine($"Дата после добавления {years} лет: {date}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        static int GetInput(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                else
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }
    }
}