namespace zadanie1
{
    internal class Program
    {
        static int[] Input()
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static void Multiples(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 3 == 0)
                {
                    Console.WriteLine($"Число кратное 3 в массиве - {a[i]}");
                }
            }
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] myArr = Input();
            Console.WriteLine("Исходные массив");
            Print(myArr);
            Multiples(myArr);
        }
    }
}
