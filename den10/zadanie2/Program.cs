namespace zadanie2
{
    using System;
    using System.Collections.Generic;

    class Contact : IComparable<Contact>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string lastName, string firstName, DateTime birthDate, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }

        public int CompareTo(Contact other)
        {
            if (other == null) return 1;
            return LastName.CompareTo(other.LastName);
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}, {BirthDate:dd.MM.yyyy}, Тел: {PhoneNumber}";
        }

        public static bool operator <(Contact a, Contact b)
        {
            if (a is null) return b is not null;
            return a.CompareTo(b) < 0;
        }

        public static bool operator >(Contact a, Contact b)
        {
            if (b is null) return a is not null;
            return a.CompareTo(b) > 0;
        }

        public static bool operator ==(Contact a, Contact b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.LastName == b.LastName;
        }

        public static bool operator !=(Contact a, Contact b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is Contact contact && this == contact;
        }

        public override int GetHashCode()
        {
            return LastName?.GetHashCode() ?? 0;
        }
    }

    class Notebook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public bool RemoveContact(string phoneNumber)
        {
            var contact = contacts.Find(c => c.PhoneNumber == phoneNumber);
            if (contact != null)
            {
                contacts.Remove(contact);
                return true;
            }
            return false;
        }

        public Contact FindByLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName)) return null;
            return contacts.Find(c =>
                c.LastName != null &&
                c.LastName.Trim().Equals(lastName.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public Contact FindByPhone(string phoneNumber)
        {
            return contacts.Find(c => c.PhoneNumber == phoneNumber);
        }

        public Contact FindByBirthDate(DateTime date)
        {
            return contacts.Find(c => c.BirthDate.Date == date.Date);
        }

        public void SortByLastName()
        {
            contacts.Sort();
        }

        public Contact this[int index]
        {
            get
            {
                if (index < 0 || index >= contacts.Count)
                    throw new IndexOutOfRangeException("Недопустимый индекс");
                return contacts[index];
            }
        }

        public void PrintAll()
        {
            foreach (var contact in contacts)
                Console.WriteLine(contact);
        }
    }

    class Program
    {
        static void Main()
        {
            Notebook notebook = new Notebook();

            notebook.AddContact(new Contact("Иванов", "Иван", new DateTime(1990, 1, 1), "123456"));
            notebook.AddContact(new Contact("Петров", "Петр", new DateTime(1985, 5, 20), "654321"));
            notebook.AddContact(new Contact("Сидоров", "Сидор", new DateTime(2000, 3, 15), "789123"));

            Console.WriteLine("Все контакты:");
            notebook.PrintAll();

            Console.WriteLine("\nСортировка по фамилии:");
            notebook.SortByLastName();
            notebook.PrintAll();

            Console.WriteLine("\nПоиск по фамилии 'Петров':");
            var found = notebook.FindByLastName("Петров");
            if (found != null)
                Console.WriteLine(found.ToString());
            else
                Console.WriteLine("Контакт не найден.");

            Console.WriteLine("\nУдаление по номеру телефона '123456':");
            notebook.RemoveContact("123456");
            notebook.PrintAll();

            Console.WriteLine("\nДоступ к записи по индексу 0:");
            Console.WriteLine(notebook[0]);
        }
    }
}
