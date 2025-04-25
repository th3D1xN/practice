namespace zadanie1
{
    interface Ix
    {
        void IxF0(int x);
        void IxF1();
    }

    interface Iy
    {
        void F0(int x);
        void F1();
    }

    interface Iz
    {
        void F0(int x);
        void F1();
    }

    class TestClass : Ix, Iy, Iz
    {
        private int w;

        public TestClass(int w)
        {
            this.w = w;
        }

        public void IxF0(int x)
        {
            Console.WriteLine($"IxF0: {10 * w}");
        }

        public void IxF1()
        {
            Console.WriteLine($"IxF1: {10 * w}");
        }

        public void F0(int x)
        {
            Console.WriteLine($"Iy.F0: {w - 10}");
        }

        public void F1()
        {
            Console.WriteLine($"Iy.F1: {w - 10}");
        }

        void Iz.F0(int x)
        {
            Console.WriteLine($"Iz.F0: {w / 10}");
        }

        void Iz.F1()
        {
            Console.WriteLine($"Iz.F1: {w / 10}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass obj = new TestClass(50);

            obj.IxF0(0);
            obj.IxF1();
            obj.F0(0);
            obj.F1();

            Iy iyRef = obj;
            iyRef.F0(0);
            iyRef.F1();

            Iz izRef = obj;
            izRef.F0(0);
            izRef.F1();

            ((Iz)obj).F0(0);
            ((Iz)obj).F1();
        }
    }
}
