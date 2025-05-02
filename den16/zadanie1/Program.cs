namespace zadanie1
{
    public class MyList<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[4];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_count] = item;
            _count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }
                return _items[index];
            }
        }

        public int Count
        {
            get { return _count; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine("Количество элементов: " + list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Элемент {i}: {list[i]}");
            }
        }
    }
}
