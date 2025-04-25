namespace zadanie2
{
    class A
    {
        private int a;
        private int b;

        public int C
        {
            get
            {
                return a + b;
            }
        }

        public A()
        {
            a = 5; 
            b = 10; 
        }

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class B : A
    {
        private int d;

        public int C2
        {
            get
            {
                switch (d)
                {
                    case 1:
                        return C + 1; 
                    case 2:
                        return C - 1;
                    default:
                        return C; 
                }
            }
        }

        public B() : base() 
        {
            d = 3; 
        }

        public B(int a, int b, int d) : base(a, b) 
        {
            this.d = d; 
        }
    }

    class Program
    {
        static void Main()
        {
            A objA = new A();
            Console.WriteLine("Свойство c для объекта A: " + objA.C);

            A objA2 = new A(7, 3);
            Console.WriteLine("Свойство c для объекта A (с параметрами): " + objA2.C);

            B objB = new B();
            Console.WriteLine("Свойство c2 для объекта B (по умолчанию): " + objB.C2);

            B objB2 = new B(8, 5, 1);
            Console.WriteLine("Свойство c2 для объекта B (с параметрами и d = 1): " + objB2.C2);

            B objB3 = new B(4, 6, 2);
            Console.WriteLine("Свойство c2 для объекта B (с параметрами и d = 2): " + objB3.C2);
        }
    }
}
