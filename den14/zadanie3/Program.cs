namespace zadanie3
{
    class MyInfo
    {
        private string name;

        public event EventHandler NameChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnNameChanged(EventArgs.Empty); 
                }
            }
        }

        protected virtual void OnNameChanged(EventArgs e)
        {
            Console.WriteLine($"[Оповещение] Имя изменено на: {name}");
            NameChanged?.Invoke(this, e);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyInfo info = new MyInfo();

            info.NameChanged += Info_NameChanged;

            Console.Write("Введите имя: ");
            string newName = Console.ReadLine();
            info.Name = newName;

            Console.Write("Введите другое имя: ");
            string anotherName = Console.ReadLine();
            info.Name = anotherName;
        }

        private static void Info_NameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Событие: имя действительно было изменено.");
        }
    }
}
