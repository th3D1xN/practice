namespace zadanie1
{
    class A
    {
        public int a;
        public int b;
        
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Method1()
        {
                double denominator = 1 + ((a + b) / 2);

                if (denominator != 0)
                {
                    double result = 1 / denominator;
                    Console.WriteLine($"Результат метода1 = {result}");
                }
                else
                {
                    Console.WriteLine("Метод1 не выполнен: деление на 0 невозможно");
                }
        }

        public void Method2()
        {
            double result = (a - b) * (a - b);
            Console.WriteLine($"Результат метода2 = {result}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A(-1, -1);
            a.Method1();
            a.Method2();

            A b = new A(3, 2);
            b.Method1();
            b.Method2();
        }
    }
}
