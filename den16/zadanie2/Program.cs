namespace zadanie2
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;
        private int _count;

        public MyDictionary()
        {
            _keys = new TKey[4];
            _values = new TValue[4];
            _count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
                throw new ArgumentException("Ключ уже существует.");

            if (_count == _keys.Length)
            {
                Array.Resize(ref _keys, _keys.Length * 2);
                Array.Resize(ref _values, _values.Length * 2);
            }

            _keys[_count] = key;
            _values[_count] = value;
            _count++;
        }

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_keys[i].Equals(key))
                        return _values[i];
                }

                throw new KeyNotFoundException("Ключ не найден.");
            }
        }

        public int Count => _count;

        private bool ContainsKey(TKey key)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_keys[i].Equals(key))
                    return true;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new MyDictionary<string, int>();
            dict.Add("apple", 3);
            dict.Add("banana", 5);
            dict.Add("cherry", 2);

            Console.WriteLine("Количество элементов: " + dict.Count);
            Console.WriteLine("Значение по ключу 'banana': " + dict["banana"]);
        }
    }
}
